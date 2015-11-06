using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EnrollmentSystem
{
    class BUS
    {
        private DAO dao;

        public BUS()
        {
            dao = new DAO();
        }

        public ThongTinTS TruyVanThongTinTS(string maTS)
        {
            var temp = dao.TruyVanThongTinTS(maTS).Rows;
            
            if (temp.Count == 0)
                return new ThongTinTS();

            return new ThongTinTS((string)temp[0][0], (string)temp[0][1], (DateTime)temp[0][2], (string)temp[0][3],
                (string)temp[0][4], (string)temp[0][5], (byte[])temp[0][6]);
        }

        public bool ThemHoSoTS(ThongTinTS ttts)
        {
            return dao.ThemThongTinTS(ttts);
        }
    }
}
