using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EnrollmentSystem
{
    class Converter
    {
        public void ExportCSV()
        {

        }

        public void ImportCSV(string candidatesFilePath, string optionsFilePath)
        {
            using (var entities = new Entities())
            {
                entities.Database.ExecuteSqlCommand("TruncateEverything");
            }

            var candidatesData = DataTableFromCSV(candidatesFilePath);
            ImportCandidatesData(candidatesData);

            var optionsData = DataTableFromCSV(optionsFilePath);
            ImportOptionsData(optionsData);
        }

        private DataTable DataTableFromCSV(string path)
        {
            var data = new DataTable();
            using (var parser = new TextFieldParser(path))
            {
                parser.SetDelimiters(new[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

                try
                {
                    var columns = parser.ReadFields();
                    foreach (string column in columns)
                    {
                        var dataColumn = new DataColumn(column);
                        dataColumn.AllowDBNull = true;
                        data.Columns.Add(dataColumn);
                    }

                    while (!parser.EndOfData)
                    {
                        var row = parser.ReadFields();
                        data.Rows.Add(row);
                    }
                }
                catch (MalformedLineException)
                {
                    throw;
                }
            }
            return data;
        }

        private void ImportCandidatesData(DataTable candidatesData)
        {
            var validColumnNames = new[] { "SBD", "HoTen", "NgaySinh", "KV", "DT", "UT",
                "Toan", "Van", "Ly", "Hoa", "Sinh", "Su", "Dia", "Anh", "Nga", "Phap", "Trung", "Duc", "Nhat" };
            var columnNames = from column in candidatesData.Columns.Cast<DataColumn>()
                              select column.ColumnName;
            ValidateColumnNames(columnNames, validColumnNames);

            var validSubjectNames = new[] { "Toán", "Văn", "Lý", "Hóa", "Sinh", "Sử", "Địa",
                                            "Anh", "Nga", "Pháp", "Trung", "Đức", "Nhật" };
            ValidateSubjectNames(validSubjectNames);


            var entities = new Entities();
            entities.Configuration.AutoDetectChangesEnabled = false;

            int id = 0;
            foreach (DataRow dataRow in candidatesData.Rows)
            {
                var candidate = CandidateFromData(dataRow);
                entities.Candidates.Add(candidate);

                id++;
                for (int i = 0; i < 13; i++)
                {
                    int subjectID = i + 1;
                    var markString = (string)dataRow[6 + i];
                    if (markString == "NA")
                        continue;

                    var mark = MarkFromData(id, subjectID, markString);
                    entities.Marks.Add(mark);
                }

                if (id % 777 == 776)
                {
                    entities.SaveChanges();
                    entities.Dispose();
                    entities = new Entities();
                    entities.Configuration.AutoDetectChangesEnabled = false;
                }
            }

            entities.SaveChanges();
            entities.Dispose();
        }

        private void ValidateColumnNames(IEnumerable<string> columnNames, string[] validColumnNames)
        {
            bool dataIsvalid = NamesAreValid(columnNames, validColumnNames);
            if (!dataIsvalid)
                throw new FormatException("Data file is not of correct format.");
        }

        private bool NamesAreValid(IEnumerable<string> names, string[] validNames)
        {
            var nameArray = names.ToArray();

            if (nameArray.Length != validNames.Length)
                return false;

            for (int i = 0; i < validNames.Length; i++)
                if (nameArray[i] != validNames[i])
                    return false;

            return true;
        }

        private void ValidateSubjectNames(string[] validSubjectNames)
        {
            using (var entities = new Entities())
            {
                var subjectNames = from subject in entities.Subjects
                                   orderby subject.ID
                                   select subject.SubjectName;

                bool dataIsvalid = NamesAreValid(subjectNames, validSubjectNames);
                if (!dataIsvalid)
                    throw new FormatException("Subject name mismatched.");
            }
        }

        private Candidate CandidateFromData(DataRow dataRow)
        {
            var candidateID = (string)dataRow[0];
            var name = (string)dataRow[1];
            var dateOfBirthString = (string)dataRow[2];
            var regionName = (string)dataRow[3];
            var beneficiaryName = (string)dataRow[4];
            var priviledge = (string)dataRow[5];

            var dateOfBirth = ValidateAndParseDate(dateOfBirthString);
            bool hasPriviledge = priviledge != "Khong";

            var regionID = RegionIDFromName(regionName);
            var beneficiaryID = BeneficiaryIDFromName(beneficiaryName);

            var password = HashcodeFromString(candidateID);

            var candidate = new Candidate()
            {
                CandidateID = candidateID,
                Name = name,
                DateOfBirth = dateOfBirth,
                RegionID = regionID,
                BeneficiaryID = beneficiaryID,
                HasPrivilege = hasPriviledge,
                Password = password
            };
            return candidate;
        }

        private DateTime ValidateAndParseDate(string dateString)
        {
            try
            {
                return DateTime.Parse(dateString);
            }
            catch (FormatException)
            {
                throw new FormatException("Date fields are not of correct format.");
            }
        }

        private int RegionIDFromName(string regionName)
        {
            using (var entities = new Entities())
            {
                var regionIDQuery = from region in entities.Regions
                                    where region.Name == regionName
                                    select region.ID;
                var regionID = ValidateAndGetFirstItem(regionIDQuery);
                return regionID;
            }
        }

        private int BeneficiaryIDFromName(string beneficiaryName)
        {
            using (var entities = new Entities())
            {
                var beneficiaryIDQuery = from beneficiary in entities.Beneficiaries
                                         where beneficiary.Name == beneficiaryName
                                         select beneficiary.ID;
                var beneficiaryID = ValidateAndGetFirstItem(beneficiaryIDQuery);
                return beneficiaryID;
            }
        }

        private int ValidateAndGetFirstItem(IEnumerable<int> query)
        {
            Debug.Assert(query.Count() == 1);
            try
            {
                return query.First();
            }
            catch (InvalidOperationException)
            {
                throw new FormatException("Column name is not of correct format.");
            }
        }

        private byte[] HashcodeFromString(string input)
        {
            var hasher = SHA256.Create();
            var byteArray = Encoding.UTF8.GetBytes(input);
            return hasher.ComputeHash(byteArray);
        }

        private Mark MarkFromData(int candidateID, int subjectID, string markString)
        {
            decimal score = ValidateAndParseMark(markString);

            var mark = new Mark()
            {
                CandidateID = candidateID,
                SubjectID = subjectID,
                Score = score
            };
            return mark;
        }

        private decimal ValidateAndParseMark(string markString)
        {
            try
            {
                return decimal.Parse(markString);
            }
            catch (FormatException)
            {
                throw new FormatException("Mark fields are not of correct format.");
            }
        }

        private void ImportOptionsData(DataTable optionsData)
        {
            var validColumnNames = new[] { "SBD", "NV1.N", "NV1.TH", "NV2.N", "NV2.TH",
                                                "NV3.N", "NV3.TH", "NV4.N", "NV4.TH"};
            var columnNames = from column in optionsData.Columns.Cast<DataColumn>()
                              select column.ColumnName;
            ValidateColumnNames(columnNames, validColumnNames);


            var entities = new Entities();
            entities.Configuration.AutoDetectChangesEnabled = false;

            int id = 0;
            foreach (DataRow dataRow in optionsData.Rows)
            {
                var option = OptionFromDataRow(dataRow);
                entities.Options.Add(option);

                id++;
                if (id % 777 == 776)
                {
                    entities.SaveChanges();
                    entities.Dispose();
                    entities = new Entities();
                    entities.Configuration.AutoDetectChangesEnabled = false;
                }
            }

            entities.SaveChanges();
            entities.Dispose();

        }

        private Option OptionFromDataRow(DataRow dataRow)
        {
            string candidateID = (string)dataRow[0],
                   major1 = (string)dataRow[1],
                   majorSubjectCombination1 = (string)dataRow[2],
                   major2 = (string)dataRow[3],
                   majorSubjectCombination2 = (string)dataRow[4],
                   major3 = (string)dataRow[5],
                   majorSubjectCombination3 = (string)dataRow[6],
                   major4 = (string)dataRow[7],
                   majorSubjectCombination4 = (string)dataRow[8];

            int theOtherKindOfID = GetCandidateID(candidateID);

            int? majorSubjectCombinationID1 = GetMajorSubjectCombinationID(major1, majorSubjectCombination1),
                 majorSubjectCombinationID2 = GetMajorSubjectCombinationID(major2, majorSubjectCombination2),
                 majorSubjectCombinationID3 = GetMajorSubjectCombinationID(major3, majorSubjectCombination3),
                 majorSubjectCombinationID4 = GetMajorSubjectCombinationID(major4, majorSubjectCombination4);

            if (majorSubjectCombinationID1 == null)
                throw new ArgumentNullException("First option cannot be null.");

            bool invalid = (majorSubjectCombinationID4 != null && (majorSubjectCombinationID3 == null || majorSubjectCombinationID2 == null))
                        || (majorSubjectCombinationID3 != null && majorSubjectCombinationID2 == null);
            if (invalid)
                throw new ArgumentException("Options must be continuous.");

            var option = new Option()
            {
                CandidateID = theOtherKindOfID,
                MajorCombinationID1 = (int)majorSubjectCombinationID1,
                MajorCombinationID2 = majorSubjectCombinationID2,
                MajorCombinationID3 = majorSubjectCombinationID3,
                MajorCombinationID4 = majorSubjectCombinationID4
            };

            return option;
        }

        private int GetCandidateID(string theOtherKindOfID)
        {
            using (var entities = new Entities())
            {
                var query = from candidate in entities.Candidates
                            where candidate.CandidateID == theOtherKindOfID
                            select candidate.ID;

                return ValidateAndGetFirstItem(query);
            }
        }

        private int? GetMajorSubjectCombinationID(string majorName, string combinationName)
        {
            if (majorName == "NA")
                return null;

            using (var entities = new Entities())
            {
                var query = from majorSubjectCombination in entities.MajorSubjectCombinations
                            where majorSubjectCombination.Major.Name == majorName
                            && majorSubjectCombination.SubjectCombination.SubjectCombinationName == combinationName
                            select majorSubjectCombination.ID;

                return ValidateAndGetFirstItem(query);
            }
        }
    }
}
