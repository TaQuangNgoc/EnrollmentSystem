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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            loadDataToGrid();
        }

        private void loadDataToGrid()
        {
            using (var context = new EnrollmentSystemEntities())
            {            
                BindingSource dataReport = new BindingSource();
                dataReport.DataSource = context.ReportViews.ToList();
            }
        }

        internal void display_for_bao_cao(DataTable v_dt)
        {
            pivotGridControl.DataSource = v_dt;
            this.ShowDialog();
        }

        private void pivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            ReportDetailsForm v_f = new ReportDetailsForm();
            v_f.Display_for_bao_cao_de(e.CreateDrillDownDataSource());
        }
    }
}
