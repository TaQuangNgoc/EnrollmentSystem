using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class F140_HO_SO_THI_SINH : Form
    {
        public F140_HO_SO_THI_SINH()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           // excute_sql("select * from ho_so_ts");
            load_data_to_sle_khu_vuc();
            load_data_to_sle_doi_tuong();
            load_data_to_sle_uu_tien();

        }

        private void load_data_to_sle_uu_tien()
        {
            m_sle_uu_tien.Properties.DataSource = (Class_dung_chung.excute_sql("select MA_UU_TIEN from dm_uu_tien")).Tables[0];
            m_sle_uu_tien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void load_data_to_sle_doi_tuong()
        {

            m_sle_doi_tuong.Properties.DataSource = Class_dung_chung.excute_sql("select MA_DOI_TUONG from dm_doi_tuong").Tables[0];
            m_sle_doi_tuong.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void load_data_to_sle_khu_vuc()
        {

            m_sle_khu_vuc.Properties.DataSource = Class_dung_chung.excute_sql("select MA_KHU_VUC from DM_KHU_VUC").Tables[0];
            m_sle_khu_vuc.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection();
                sqlConnection1.ConnectionString = "Data Source=anhpt-pc\\sqlexpressr2;" + "Initial Catalog=KSTN_TSBK;" + "User id=sa;" + "Password=sa123456;";
                // SqlDataReader reader;
                sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("pr_ho_so_ts", sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MA_TS", m_txt_so_bao_danh.Text));
                cmd.Parameters.Add(new SqlParameter("@HO_TEN", m_txt_so_bao_danh.Text));
                cmd.Parameters.Add(new SqlParameter("@KHU_VUC", m_sle_khu_vuc.EditValue));
                cmd.Parameters.Add(new SqlParameter("@DOI_TUONG", m_sle_doi_tuong.EditValue ));
                cmd.Parameters.Add(new SqlParameter("@UU_TIEN", m_sle_uu_tien.EditValue));
                cmd.ExecuteReader();
                MessageBox.Show("Nhập dữ liệu thành công!");
                F100_CHI_TIET_NGUYEN_VONG v_f = new F100_CHI_TIET_NGUYEN_VONG();
                v_f.display_for_chi_tiet(m_txt_so_bao_danh.Text, m_txt_ho_ten.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Có chút vấn đề về tín hiệu đường truyền. Vui lòng truy cập lại sau!");
            }
           
        }


      
    }
}
