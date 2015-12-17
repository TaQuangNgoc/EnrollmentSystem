using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem.Algorithm
{
   public class Admission
    {
        //public void 

        private DataTable XT(ThiSinh[] dsTS, NhomNganh[] dsNNganh)
        {
            Queue<ThiSinh> hdxt = new Queue<ThiSinh>(dsTS);                     // hang doi xet tuyen

            ThiSinh ts;                                                         // thi sinh dang xet
            NhomNganh nhomNganh;                                                // nganh dang xet

            // qua trinh xet tuyen
            while (hdxt.Count > 0)
            {
                ts = hdxt.Dequeue();
                ts.TangNVDX();
                nhomNganh = ts.GetNVDX();

                if (ts.TrungTuyenTamThoi())
                {
                    nhomNganh.AddToDSTTTT(ts);
                    var temp = nhomNganh.RemoveFromDSTTTT();

                    if (temp == null)
                        continue;

                    foreach (ThiSinh tsBiLoai in temp)
                    {
                        if (tsBiLoai.ConNguyenVong())
                        {
                            hdxt.Enqueue(tsBiLoai);
                        }
                        // else them vao danh sach truot
                    }
                }
                else
                    if (ts.ConNguyenVong())
                        hdxt.Enqueue(ts);
            }

            // tra ve

            DataTable output = new DataTable();
            output.Columns.AddRange(new DataColumn[]{new DataColumn("MaNN"), new DataColumn("ChiTieu"),
                                                    new DataColumn("SoLuong"), new DataColumn("DiemChuan")});
            foreach (NhomNganh nn in dsNNganh)
            {
                //output.Rows.Add(new DataRow(new object[]{nn.maNN, nn.chiTieu, nn.GetDSTT().Count, nn.GetDiemChuan()}));
                DataRow temp = output.NewRow();
                temp[0] = nn.MaNN;
                temp[1] = nn.ChiTieu;
                temp[2] = nn.GetDSTT().Count;
                temp[3] = nn.GetDiemChuan();
                output.Rows.Add(temp);
            }

            DataTable output2 = new DataTable();
            output2.Columns.AddRange(new DataColumn[]{new DataColumn("SBD"), new DataColumn("DiemTrungTuyen"),
                                                      new DataColumn("MaNNganh")});

            foreach (ThiSinh ts1 in dsTS)
            {
                DataRow temp = output2.NewRow();
                temp[1] = ts1.GetDiemDX();
                temp[2] = ts1.GetNVDX().MaNN;
                output2.Rows.Add(temp);
            }

            DataView dv = output2.DefaultView;
            dv.Sort = "SBD asc";

            DataTable sortedDT = dv.ToTable();

            return output;
        }
    }
}
