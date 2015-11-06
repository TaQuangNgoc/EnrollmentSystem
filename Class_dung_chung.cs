using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
    class Class_dung_chung
    {
        public static DataSet excute_sql(string select_state)
        {
            var ds = new DataSet();
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = "Data Source=anhpt-pc\\sqlexpressr2;" + "Initial Catalog=KSTN_TSBK;" + "User id=sa;" + "Password=sa123456;";
            SqlCommand cmd = new SqlCommand();
            // SqlDataReader reader;

            cmd.CommandText = select_state;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
            return ds;
        }
    }
}
