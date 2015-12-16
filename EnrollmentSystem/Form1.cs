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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var entities = new ESGEntities();
            Subjects subject = new Subjects() { ID = 1, SubjectName = "Math" };
            entities.Subjects.Add(subject);
            entities.SaveChanges();
        
        }
    }
}
