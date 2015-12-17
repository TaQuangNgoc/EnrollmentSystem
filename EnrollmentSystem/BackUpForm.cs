using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;

namespace EnrollmentSystem
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }
        
        private void browseButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                pathTextBox.Text = openFileDialog.FileName;
        }

        private void backUpButton_Click(object sender, EventArgs e)
        {
            // check stuffs
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            // check stuffs

            var converter = new Converter();
            string folderPath = pathTextBox.Text,
                candidatesFileName = candidatesFileNameTextBox.Text,
                optionsFileName = optionsFileNameTextBox.Text;
            converter.ImportCSV(folderPath, candidatesFileName, optionsFileName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

