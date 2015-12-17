using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem.Algorithm
{
    class NhomNganh
    {
        private List<ThiSinh> dsTTTT;           // danh sach trung tuyen tam thoi

        private readonly int chiTieu;
        private readonly string maNN;

        public int ChiTieu
        {
            get
            {
                return chiTieu;
            }
        }

        public string MaNN
        {
            get
            {
                return maNN;
            }
        }

        public NhomNganh(string maNN, int chiTieu)
        {
            this.maNN = maNN;
            this.chiTieu = chiTieu;
            dsTTTT = new List<ThiSinh>();
        }

        // them thi sinh vao danh sach trung tuyen tam thoi
        public void AddToDSTTTT(ThiSinh ts)
        {
            dsTTTT.Add(ts);
            dsTTTT.Sort();
        }

        // loai bo cac thi sinh khoi danh sach trung tuyen tam thoi
        public List<ThiSinh> RemoveFromDSTTTT()
        {
            if (dsTTTT.Count <= chiTieu)
                return null;

            float diemSan = dsTTTT[chiTieu - 1].GetDiemDX();

            List<ThiSinh> dsTSBiLoai = new List<ThiSinh>();

            ThiSinh temp = dsTTTT.Last();
            while (temp.GetDiemDX() < diemSan)
            {
                dsTSBiLoai.Add(temp);
                dsTTTT.Remove(temp);                        // can use index instead

                temp = dsTTTT.Last();
            }

            return dsTSBiLoai;
        }

        // tra ve danh sach trung tuyen cuoi cung
        public List<ThiSinh> GetDSTT()
        {
            return dsTTTT;
        }

        // tra ve diem chuan
        public float GetDiemChuan()
        {
            if (dsTTTT.Count == 0)
                return 0;

            if (dsTTTT.Count < chiTieu)
                return dsTTTT.Last().GetDiemDX();

            return dsTTTT[chiTieu - 1].GetDiemDX();
        }
    }
}
