namespace EnrollmentSystem
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram3 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView5 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView6 = new DevExpress.XtraCharts.PieSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.CountCandidate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 68);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo kết quả tuyển sinh theo ngành";
            // 
            // chartControl1
            // 
            simpleDiagram3.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram3;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartControl1.Location = new System.Drawing.Point(753, 68);
            this.chartControl1.Name = "chartControl1";
            series3.Name = "Series 1";
            pieSeriesView5.RuntimeExploding = false;
            pieSeriesView5.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series3.View = pieSeriesView5;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            pieSeriesView6.RuntimeExploding = false;
            pieSeriesView6.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            this.chartControl1.SeriesTemplate.View = pieSeriesView6;
            this.chartControl1.Size = new System.Drawing.Size(344, 440);
            this.chartControl1.TabIndex = 2;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.CountCandidate,
            this.pivotGridField3});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 68);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(753, 440);
            this.pivotGridControl.TabIndex = 0;
            this.pivotGridControl.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Số báo danh";
            this.pivotGridField1.FieldName = "CandidateID";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // CountCandidate
            // 
            this.CountCandidate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.CountCandidate.AreaIndex = 0;
            this.CountCandidate.Caption = "Số lượng trúng tuyển";
            this.CountCandidate.FieldName = "CandidateID";
            this.CountCandidate.Name = "CountCandidate";
            this.CountCandidate.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Ngành trúng tuyển";
            this.pivotGridField3.FieldName = "MajorName";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 508);
            this.Controls.Add(this.pivotGridControl);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportForm";
            this.Text = "F130_BAO_CAO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField CountCandidate;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}