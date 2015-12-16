﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem
{
    class ThiSinh : IComparable
    {
        private int nvdx;                       // index cua nguyen vong dang xet
        private NhomNganh[] nguyenVong;

        private readonly float[] diem;
        private readonly ThongTinTS ttts;

        public string SBD { get; set; }         // to be removed

        public ThongTinTS TTTS
        {
            get
            {
                return ttts;
            }
        }

        // ham khoi tao
        public ThiSinh(string sbd, NhomNganh[] nguyenVong, float[] diem)
        {
            this.SBD = sbd;
            this.nguyenVong = nguyenVong;
            this.diem = diem;

            nvdx = -1;
        }

        // tra ve diem cua nguyen vong dang xet
        public float GetDiemDX()
        {
            return diem[nvdx];
        }

        // tra ve nguyen vong dang xet
        public NhomNganh GetNVDX()
        {
            return nguyenVong[nvdx];
        }

        // tang nguyen vong dang xet len 1
        public void TangNVDX()
        {
            nvdx++;
        }

        // xet xem thi sinh co trung tuyen tam thoi hay khong
        public bool TrungTuyenTamThoi()
        {
            var temp = nguyenVong[nvdx].GetDSTT();
            if (temp.Count < nguyenVong[nvdx].ChiTieu)
                return true;

            ThiSinh tsTruHang = temp.Last();
            return diem[nvdx] >= tsTruHang.diem[tsTruHang.nvdx];
        }

        public bool ConNguyenVong()
        {
            return nvdx < 3 && nguyenVong[nvdx + 1] != null;
        }

        // implement IComparable de sap xep danh sach trung tuyen
        int IComparable.CompareTo(object obj)
        {
            ThiSinh other = (ThiSinh)obj;
            return -diem[nvdx].CompareTo(other.diem[other.nvdx]);
        }
    }
}
