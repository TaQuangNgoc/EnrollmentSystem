using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Ribbon;
using EnrollmentSystem.Algorithm;

namespace EnrollmentSystem
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            xtraTabbedMdiManager1.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage1;
        }

        //form in tag

        ReportForm v_f130_bao_cao;
        CandidateForm v_f140_ho_so_thong_tin;
        PreferencesForm v_f100_chi_tiet_nguyen_vong;
        AdmissionList admissionListForm;
        NonAdmissionList nonAdmissionListForm;

        private void m_cmd_thong_tin_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (v_f140_ho_so_thong_tin == null || !IsFormOpen(v_f140_ho_so_thong_tin))
            {
                v_f140_ho_so_thong_tin = new CandidateForm();
                v_f140_ho_so_thong_tin.MdiParent = this;
                v_f140_ho_so_thong_tin.Show();
            }
            else
            {
                v_f140_ho_so_thong_tin.Focus();
            }
        }

        private void m_cmd_nguyen_vong_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            if (v_f100_chi_tiet_nguyen_vong == null || !IsFormOpen(v_f140_ho_so_thong_tin))
            {
                v_f100_chi_tiet_nguyen_vong = new PreferencesForm();
                v_f100_chi_tiet_nguyen_vong.MdiParent = this;
                v_f100_chi_tiet_nguyen_vong.Show();
            }
            else
            {
                v_f140_ho_so_thong_tin.Focus();
            }
        }

        private void m_btn_report_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (v_f130_bao_cao == null || !IsFormOpen(v_f130_bao_cao))
            {
                v_f130_bao_cao = new ReportForm();
                v_f130_bao_cao.MdiParent = this;
                v_f130_bao_cao.Show();
            }
            else
            {
                v_f130_bao_cao.Focus();
            }
        }

        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }      

        private void buttonAdmissionList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (admissionListForm == null || !IsFormOpen(admissionListForm))
            {
                admissionListForm = new AdmissionList();
                admissionListForm.MdiParent = this;
                admissionListForm.Show();
            }
            else
            {
                admissionListForm.Focus();
            }
        }

        private void buttonNonAdmissionList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nonAdmissionListForm == null || !IsFormOpen(nonAdmissionListForm))
            {
                nonAdmissionListForm = new NonAdmissionList();
                nonAdmissionListForm.MdiParent = this;
                nonAdmissionListForm.Show();
            }
            else
            {
                nonAdmissionListForm.Focus();
            }

        }

       

        private void backUpButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var backUpForm = new BackUpForm();
            backUpForm.ShowDialog();
        }

        private void calculateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var admission = new Admission();
            admission.StartAdmission();
        }
    }
}