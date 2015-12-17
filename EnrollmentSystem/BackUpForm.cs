using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;
using System.IO;

namespace EnrollmentSystem
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void candidatesBrowseButton_Click(object sender, EventArgs e)
        {
            string path = GetPathFromDialog();
            if (path != "")
                candidatesFilePathTextBox.Text = path;
        }

        private void optionsBrowseButton_Click(object sender, EventArgs e)
        {
            string path = GetPathFromDialog();
            if (path != "")
                optionsFilePathTextBox.Text = path;
        }

        private string GetPathFromDialog()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                return openFileDialog.FileName;
            return "";
        }

        private void backUpButton_Click(object sender, EventArgs e)
        {
            // check stuffs
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            var converter = new Converter();
            string candidatesFilePath = candidatesFilePathTextBox.Text,
                    optionsFilePath = optionsFilePathTextBox.Text;

            bool pathIsValid = File.Exists(candidatesFilePath) && File.Exists(optionsFilePath);
            if (!pathIsValid)
            {
                MessageBox.Show("Hãy nhập một đường dẫn hợp lệ.");
                return;
            }

            string message = "Bạn có chắc không? Tất cả dữ liệu hiện tại sẽ mất.";
            var result = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result != DialogResult.OK)
                return;

            try
            {
                converter.ImportCSV(candidatesFilePath, optionsFilePath);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng file csv.", "Lỗi");
                return;
            }

            MessageBox.Show("Thành công.");
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

