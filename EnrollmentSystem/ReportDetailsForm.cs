﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class ReportDetailsForm : Form
    {
        public ReportDetailsForm()
        {
            InitializeComponent();
        }

        internal void Display_for_bao_cao_de(DevExpress.XtraPivotGrid.PivotDrillDownDataSource pivotDrillDownDataSource)
        {
            m_grc.DataSource = pivotDrillDownDataSource;
            this.ShowDialog();
        }
    }
}
