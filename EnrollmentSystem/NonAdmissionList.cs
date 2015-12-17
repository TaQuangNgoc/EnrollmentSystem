using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class NonAdmissionList : Form
    {
        public NonAdmissionList()
        {
            InitializeComponent();
        }

        private void ReportMajor_Load(object sender, EventArgs e)
        {
            using (var context = new EnrollmentSystemEntities())
            {
                var res = from candidate in context.ReportViews
                          where candidate.AdmittingMajorSubjectCombinationID != null
                          select candidate;
                gridControl.DataSource = res.ToList();  
            }
        }
    }
}
