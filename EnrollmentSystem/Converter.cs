using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
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
            var candidatesData = DataTableFromCSV(folderPath + candidatesFileName);
            ImportCandidatesData(candidatesData);

            var optionsData = DataTableFromCSV(folderPath + candidatesFileName);
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

            bool dataIsvalid = DataIsValid(candidatesData, validColumnNames);
            if (!dataIsvalid)
                throw new FormatException("Data file is not of correct format.");

            foreach (DataRow dataRow in candidatesData.Rows)
            {
                var candidateID = (string)dataRow[0];
                var name = (string)dataRow[1];
                var dateOfBirthString = (string)dataRow[2];
                var regionName = (string)dataRow[3];
                var beneficiaryName = (string)dataRow[4];
                var priviledge = (string)dataRow[5];

                var mathString = (string)dataRow[6];
                var literatureString = (string)dataRow[7];
                var physicsString = (string)dataRow[8];
                var chemistryString = (string)dataRow[9];
                var biologyString = (string)dataRow[10];
                var historyString = (string)dataRow[11];
                var geographyString = (string)dataRow[12];

                var englishString = (string)dataRow[13];
                var russianString = (string)dataRow[14];
                var frenchString = (string)dataRow[15];
                var chineseString = (string)dataRow[16];
                var germanString = (string)dataRow[17];
                var japaneseString = (string)dataRow[18];

                DateTime dateOfBirth = ValidateAndParseDate(dateOfBirthString);

                bool hasPriviledge = priviledge != "";

                decimal math = ValidateAndParseMark(mathString),
                        literature = ValidateAndParseMark(literatureString),
                        physics = ValidateAndParseMark(physicsString),
                        chemistry = ValidateAndParseMark(chemistryString),
                        biology = ValidateAndParseMark(biologyString),
                        history = ValidateAndParseMark(historyString),
                        geography = ValidateAndParseMark(geographyString),
                        english = ValidateAndParseMark(englishString),
                        russian = ValidateAndParseMark(russianString),
                        french = ValidateAndParseMark(frenchString),
                        chinese = ValidateAndParseMark(chineseString),
                        german = ValidateAndParseMark(germanString),
                        japanese = ValidateAndParseMark(japaneseString);

                var regionID = RegionIDFromName(regionName);
                var beneficiaryID = RegionIDFromName(beneficiaryName);

                var password = HashcodeFromString(candidateID + "randomSalt");

                var candidate = new Candidate()
                {
                    CandidateID = candidateID,
                    Name = name,
                    DateOfBirth = dateOfBirth,
                    RegionID = regionID,
                    BeneficiaryID = beneficiaryID,
                    HasPrivilege = hasPriviledge,
                    Pasword = password
                };
            }
        }

        private bool DataIsValid(DataTable data, string[] validColumnNames)
        {
            var dataColumns = data.Columns;
            if (dataColumns.Count != validColumnNames.Length)
                return false;

            for (int i = 0; i < validColumnNames.Length; i++)
                if (dataColumns[i].ColumnName != validColumnNames[i])
                    return false;

            return true;
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

        private int RegionIDFromName(string regionName)
        {
            using (var entities = new Entities())
            {
                var regionIDQuery = from region in entities.Regions
                                    where region.RegionName == regionName
                                    select region.ID;
                var regionID = ValidateAndGetQueryID(regionIDQuery);
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
                throw new FormatException("Beneficiary name is not of correct format.");
            }
        }

        private byte[] HashcodeFromString(string input)
        {
            var hasher = SHA256.Create();
            var byteArray = Encoding.Unicode.GetBytes(input);
            return hasher.ComputeHash(byteArray);
        }

        private void ImportOptionsData(DataTable optionsData)
        {

        }
    }
}
