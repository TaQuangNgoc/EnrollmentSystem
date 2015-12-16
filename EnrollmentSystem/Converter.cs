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
                    var replaced = from cell in row
                                   select (cell == "") ? null : cell;
                    data.Rows.Add(replaced);
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
                string candidateID = (string)dataRow[0];
                string name = (string)dataRow[1];
                DateTime dateOfBirth = (DateTime)dataRow[2];
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
