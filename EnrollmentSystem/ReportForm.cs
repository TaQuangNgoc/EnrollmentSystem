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
               var res = from data in  context.ReportViews
                         where data.AdmittingMajorSubjectCombinationID != null
                         select data;
               pivotGridControl.DataSource = res.ToList();
            }
        }

       
       
    }
}
