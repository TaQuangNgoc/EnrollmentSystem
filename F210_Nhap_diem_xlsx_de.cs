using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;

namespace EnrollmentSystem
{
    public partial class F210_Nhap_diem_xlsx_de : Form
    {
        DataTable m_dt_ho_so_thi_sinh;
        DataTable m_dt_nguyen_vong;
        DataTable m_dt_chi_tieu;
        

        public F210_Nhap_diem_xlsx_de()
        {
            InitializeComponent();
          
        }

      

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
          //  openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                m_txt_path_ho_so.Text = openFileDialog1.FileName;
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
       //     ImportFile();
            DataTable v_dt = new DataTable();
            v_dt = GetDataTabletFromCSVFile(m_txt_path_ho_so.Text);
            F130_BAO_CAO v_f = new F130_BAO_CAO();
            v_f.display_for_bao_cao(v_dt);
            m_dt_ho_so_thi_sinh= GetDataTabletFromCSVFile(m_txt_path_ho_so.Text);
            xu_ly_ho_so();
            m_dt_nguyen_vong= GetDataTabletFromCSVFile(m_txt_file_nguyen_vong_xet_tuyen.Text);
            xu_ly_nguyen_vong();
            //m_dt_chi_tieu= GetDataTabletFromCSVFile(m_txt_path_chi_tieu.Text);
            //xu_ly_chi_tieu();
            this.Close();
        }

        private void xu_ly_chi_tieu()
        {
            System.Data.DataView view = new System.Data.DataView(m_dt_nguyen_vong);
            System.Data.DataTable selected = view.ToTable("Selected", false, "SBD", "HOTEN", "NGAYSINH", "KV", "DT", "UT");
            update_db_from_dt(selected, "HO_SO_TS");
        }

        private void xu_ly_nguyen_vong()
        {
            System.Data.DataView view = new System.Data.DataView(m_dt_nguyen_vong);
            System.Data.DataTable selected = view.ToTable("Selected", false, "SBD", "HOTEN", "NGAYSINH", "KV", "DT", "UT");
            update_db_from_dt(selected, "HO_SO_TS");
          
        }

        private void update_db_from_dt(DataTable selected, string destinationTableName)
        {
            SqlConnection _connection = new SqlConnection();
            _connection.ConnectionString= "Data Source=anhpt-pc\\sqlexpressr2;" + "Initial Catalog=KSTN_TSBK;" + "User id=sa;" + "Password=sa123456;";
 
            using (var bulkCopy = new SqlBulkCopy(_connection.ConnectionString, SqlBulkCopyOptions.KeepIdentity))
            {
                // my DataTable column names match my SQL Column names, so I simply made this loop. However if your column names don't match, just pass in which datatable name matches the SQL column name in Column Mappings
                foreach (DataColumn col in selected.Columns)
                {
                    bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                }
                bulkCopy.BulkCopyTimeout = 600;
                bulkCopy.DestinationTableName = destinationTableName;
                bulkCopy.WriteToServer(selected);
            }
        }

        private void xu_ly_ho_so()
        {
            System.Data.DataView view = new System.Data.DataView(m_dt_ho_so_thi_sinh);
            System.Data.DataTable selected = view.ToTable("Selected", false, "SBD", "HOTEN", "NGAYSINH", "KV","DT","UT");
            update_db_from_dt(selected, "HO_SO_TS");
        }

        public void display(ref string v_str_path)
        {
            this.ShowDialog();
            v_str_path = m_txt_path_ho_so.Text;
        }

     
        

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
              using(TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                 {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return csvData;
        }

        
      }
    }

