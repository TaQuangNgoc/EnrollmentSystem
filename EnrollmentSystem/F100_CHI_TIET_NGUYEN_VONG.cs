using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class F100_CHI_TIET_NGUYEN_VONG : Form
    {
        DataSet m_ds_nganh;
        DataSet m_ds_to_hop;
        public F100_CHI_TIET_NGUYEN_VONG()
        {
            InitializeComponent();
           
        }

        private void load_data_to_sle_to_hop()
        {
            m_sle_to_hop_nv1.Properties.DataSource = m_ds_to_hop.Tables[0];
            m_sle_to_hop_nv1.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_to_hop_nv2.Properties.DataSource = m_ds_to_hop.Tables[0];
            m_sle_to_hop_nv2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_to_hop_nv3.Properties.DataSource = m_ds_to_hop.Tables[0];
            m_sle_to_hop_nv3.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_to_hop_nv4.Properties.DataSource = m_ds_to_hop.Tables[0];
            m_sle_to_hop_nv4.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void load_data_to_sle_nganh()
        {

            m_sle_nganh_nv1.Properties.DataSource = m_ds_nganh.Tables[0];
            m_sle_nganh_nv1.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_nganh_nv2.Properties.DataSource = m_ds_nganh.Tables[0];
            m_sle_nganh_nv2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_nganh_nv3.Properties.DataSource = m_ds_nganh.Tables[0];
            m_sle_nganh_nv3.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_nganh_nv4.Properties.DataSource = m_ds_nganh.Tables[0];
            m_sle_nganh_nv4.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

        }

        internal void display_for_chi_tiet(string v_str_sbd, string v_ho_ten)
        {
            m_txt_ho_ten.Text = v_ho_ten;
            m_txt_sbd.Text = v_str_sbd;
           m_ds_nganh= Class_dung_chung.excute_sql("select * from NGANH");
           m_ds_to_hop = Class_dung_chung.excute_sql("select * from NGANH_TO_HOP");
            this.ShowDialog();

        }

        private void F100_CHI_TIET_NGUYEN_VONG_Load(object sender, EventArgs e)
        {
            load_data_to_sle_nganh();
            load_data_to_sle_to_hop();
        }
    }
}
