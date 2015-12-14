using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EnrollmentSystem
{
    class DAO
    {
        private DatabaseConnection conn;

        public DAO()
        {
            conn = new DatabaseConnection();
        }
        
        //
        // account query
        //

        // query

        private string CheckLoginDetailQuery(string id, string password)
        {
            return string.Format("SELECT TOP 1 [isAdmin] FROM [Member] WHERE [ID] = @" + id + " AND [password] = @" + password);
        }

        private string SelectAccountQuery(string id)
        {
            return string.Format("SELECT * FROM [Member] WHERE [ID] = @" + id);
        }

        private string UpdateAccountQuery(string sdt, string email, string team, string password, string id)
        {
            return string.Format("UPDATE [Member] SET [telNo] = @" + sdt + ", [email] = @" + email + ", [teamID] = @" + team +
                ", [password] = @" + password + " WHERE [ID] = @" + id);
        }

        public DataTable TruyVanThongTinTS(string maTS)
        {
            string query = string.Format("SELECT * FROM [HO_SO_TS] WHERE [MA_TS] = " + "@maTS");

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maTS", SqlDbType.NVarChar, 50);
            sqlParameters[0].Value = maTS;

            return conn.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool ThemThongTinTS(ThongTinTS ttts)
        {
            string query = string.Format("INSERT INTO [HO_SO_TS](MA_TS, HO_TEN, NGAY_SINH, KHU_VUC, DOI_TUONG, UU_TIEN, PASSWORD)"
                        + " VALUES (" + "@maTS" + ", " + "@hoTen" + ", " + "@ngaySinh" + ", " + "@khuVuc" + ", " + "@doiTuong"
                        + ", " + "@uuTien" + ", " + "@password" + ")");

            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@maTS", SqlDbType.NVarChar, 50);
            sqlParameters[0].Value = ttts.maTS;
            sqlParameters[1] = new SqlParameter("@hoTen", SqlDbType.NChar, 50);
            sqlParameters[1].Value = ttts.hoTen;
            sqlParameters[2] = new SqlParameter("@ngaySinh", SqlDbType.Date);
            sqlParameters[2].Value = ttts.ngaySinh;
            sqlParameters[3] = new SqlParameter("@khuVuc", SqlDbType.NVarChar, 20);
            sqlParameters[3].Value = ttts.khuVuc;
            sqlParameters[4] = new SqlParameter("@doiTuong", SqlDbType.NVarChar, 20);
            sqlParameters[4].Value = ttts.doiTuong;
            sqlParameters[5] = new SqlParameter("@uuTien", SqlDbType.NVarChar, 20);
            sqlParameters[5].Value = ttts.uuTien;
            sqlParameters[6] = new SqlParameter("@password", SqlDbType.Binary, 32);
            sqlParameters[6].Value = ttts.password;

            return conn.ExecuteInsertQuery(query, sqlParameters);
        }
    }
}
