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
    public partial class AdmissionList : Form
    {
        public AdmissionList()
        {
            InitializeComponent();
        }

        private void AdmissionList_Load(object sender, EventArgs e)
        {
            using (var context  = new Entities())
            {
                var res = from candidate in context.Candidates
                          join majorsubjectconbination in context.MajorSujectCombinationsViews
                          on candidate.AdmittingMajorSubjectCombinationID equals majorsubjectconbination.ID
                          where candidate.AdmittingMajorSubjectCombinationID.HasValue
                          select new { CandidateID = candidate.CandidateID,candidate.AdmissionMark, majorName = majorsubjectconbination.Name };
                gridControl.DataSource = res.ToList();           
            }
        }


    }
}
