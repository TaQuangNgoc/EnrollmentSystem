using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var region = (string)dataRow[3];
                var beneficiary = (string)dataRow[4];
                var priviledge = (string)dataRow[5];
                var mathString = (string)dataRow[6];
                var literatureString = (string)dataRow[7];
                var physicsString = (string)dataRow[8];
                var chemistryString = (string)dataRow[9];
                var biologyString = (string)dataRow[10];
                var historyString = (string)dataRow[11];
                var geographyString = (string)dataRow[12];
                var englishString = (string)dataRow[13];
                /*
                var geographyString = (string)dataRow[12];
                var geographyString = (string)dataRow[12];
                var geographyString = (string)dataRow[12];
                var geographyString = (string)dataRow[12];
                var geographyString = (string)dataRow[12];
                */

                try
                {
                }
                catch (FormatException)
                {
                    throw new FormatException("Date fields are not of correct format.");
                }
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

        private void ImportOptionsData(DataTable optionsData)
        {

        }
    }
}
