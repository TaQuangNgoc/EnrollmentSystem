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

        public void ImportCSV(string folderPath, string candidatesFileName, string optionsFileName)
        {
            var candidatesData = DataTableFromCSV(folderPath + "\\" + candidatesFileName);
            ImportCandidatesData(candidatesData);

            var optionsData = DataTableFromCSV(folderPath + "\\" + candidatesFileName);
            ImportCandidatesData(optionsData);
        }

        private DataTable DataTableFromCSV(string path)
        {
            var data = new DataTable();
            using (var parser = new TextFieldParser(path))
            {
                parser.SetDelimiters(new[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

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

            var candidatesColumns = new[] { "CandidateID", "Name", "DateOfBirth", "RegionID", "BeneficiaryID",
                "HasPrivilege", "Password", "AdmittingMajorSubjectCombinationID", "AdmissionMark" };
            var candidatesTable = new DataTable();
            foreach (var columnName in candidatesColumns)
                candidatesTable.Columns.Add(columnName);

            var marksColumns = new[] { "CandidateID", "SubjectID", "Score" };
            var marksTable = new DataTable();
            foreach (var columnName in marksColumns)
                marksTable.Columns.Add(columnName);

            int id = 0;
            foreach (DataRow dataRow in candidatesData.Rows)
            {
                var candidate = CandidateFromData(dataRow);
                var candidateRow = candidatesTable.NewRow();
                candidateRow[0] = candidate.CandidateID;
                candidateRow[1] = candidate.Name;
                candidateRow[2] = candidate.DateOfBirth;
                candidateRow[3] = candidate.RegionID;
                candidateRow[4] = candidate.BeneficiaryID;
                candidateRow[5] = candidate.HasPrivilege;
                candidateRow[6] = candidate.Password;
                candidateRow[7] = null;
                candidateRow[8] = null;

                candidatesTable.Rows.Add(candidateRow);

                id++;
                for (int i = 0; i < 13; i++)
                {
                    int subjectID = i + 1;
                    var markString = (string)dataRow[6 + i];
                    if (markString == "NA")
                        continue;

                    var mark = MarkFromData(id, subjectID, markString);
                    var markRow = marksTable.NewRow();
                    markRow[0] = mark.CandidateID;
                    markRow[1] = mark.SubjectID;
                    markRow[2] = mark.Score;

                    marksTable.Rows.Add(markRow);
                }
            }

            BulkCopy(candidatesTable, "Candidates");
            BulkCopy(marksTable, "Marks");
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
            using (var entities = new EnrollmentSystemEntities())
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
            using (var entities = new EnrollmentSystemEntities())
            {
                var regionIDQuery = from region in entities.Regions
                                    where region.Name == regionName
                                    select region.ID;
                var regionID = ValidateAndGetQueryID(regionIDQuery);
                return regionID;
            }
        }

        private int BeneficiaryIDFromName(string beneficiaryName)
        {
            using (var entities = new EnrollmentSystemEntities())
            {
                var beneficiaryIDQuery = from beneficiary in entities.Beneficiaries
                                         where beneficiary.Name == beneficiaryName
                                         select beneficiary.ID;
                var beneficiaryID = ValidateAndGetQueryID(beneficiaryIDQuery);
                return beneficiaryID;
            }
        }

        private int ValidateAndGetQueryID(IEnumerable<int> query)
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

        private void BulkCopy(DataTable data, string tableName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentSystemEntities"].ConnectionString;

            using (var bulkCopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.KeepIdentity))
            {
                foreach (DataColumn column in data.Columns)
                    if (column.ColumnName != "ID")
                        bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);

                bulkCopy.BulkCopyTimeout = 600;
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.WriteToServer(data);
            }
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

        }
    }
}
