using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnrollmentSystem
{
    struct ThongTinTS
    {
        public readonly string maTS, hoTen, khuVuc, doiTuong, uuTien;
        public readonly DateTime ngaySinh;
        public readonly Byte[] password;

        public ThongTinTS(string maTS, string hoTen, DateTime ngaySinh, string khuVuc,
                            string doiTuong, string uuTien, Byte[] password)
        {
            this.maTS = maTS;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.khuVuc = khuVuc;
            this.doiTuong = doiTuong;
            this.uuTien = uuTien;
            this.password = password;
        }
    }
}
