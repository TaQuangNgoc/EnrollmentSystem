namespace EnrollmentSystem
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_sle_uu_tien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_sle_doi_tuong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.m_sle_khu_vuc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.m_txt_ho_ten = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_so_bao_danh = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_uu_tien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_doi_tuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_khu_vuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_sle_uu_tien);
            this.groupControl1.Controls.Add(this.m_sle_doi_tuong);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.m_sle_khu_vuc);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.m_txt_ngay_sinh);
            this.groupControl1.Controls.Add(this.m_txt_ho_ten);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.m_txt_so_bao_danh);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 285);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THÔNG TIN THÍ SINH";
            // 
            // m_sle_uu_tien
            // 
            this.m_sle_uu_tien.EditValue = "Chọn loại ưu tiên";
            this.m_sle_uu_tien.Location = new System.Drawing.Point(530, 186);
            this.m_sle_uu_tien.Name = "m_sle_uu_tien";
            this.m_sle_uu_tien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_uu_tien.Properties.DisplayMember = "MA_UU_TIEN";
            this.m_sle_uu_tien.Properties.ValueMember = "MA_UU_TIEN";
            this.m_sle_uu_tien.Properties.View = this.gridView3;
            this.m_sle_uu_tien.Size = new System.Drawing.Size(221, 20);
            this.m_sle_uu_tien.TabIndex = 17;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // m_sle_doi_tuong
            // 
            this.m_sle_doi_tuong.EditValue = "Chọn đối tượng";
            this.m_sle_doi_tuong.Location = new System.Drawing.Point(530, 126);
            this.m_sle_doi_tuong.Name = "m_sle_doi_tuong";
            this.m_sle_doi_tuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_doi_tuong.Properties.DisplayMember = "MA_DOI_TUONG";
            this.m_sle_doi_tuong.Properties.ValueMember = "MA_DOI_TUONG";
            this.m_sle_doi_tuong.Properties.View = this.gridView2;
            this.m_sle_doi_tuong.Size = new System.Drawing.Size(221, 20);
            this.m_sle_doi_tuong.TabIndex = 16;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(429, 193);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "ƯU TIÊN";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(429, 133);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "ĐỐI TƯỢNG";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(468, 274);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 13);
            this.labelControl8.TabIndex = 11;
            // 
            // m_sle_khu_vuc
            // 
            this.m_sle_khu_vuc.EditValue = "Chọn khu vực";
            this.m_sle_khu_vuc.Location = new System.Drawing.Point(129, 183);
            this.m_sle_khu_vuc.Name = "m_sle_khu_vuc";
            this.m_sle_khu_vuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_khu_vuc.Properties.DisplayMember = "MA_KHU_VUC";
            this.m_sle_khu_vuc.Properties.ValueMember = "MA_KHU_VUC";
            this.m_sle_khu_vuc.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_khu_vuc.Size = new System.Drawing.Size(221, 20);
            this.m_sle_khu_vuc.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "KHU VỰC";
            // 
            // m_txt_ngay_sinh
            // 
            this.m_txt_ngay_sinh.Location = new System.Drawing.Point(530, 67);
            this.m_txt_ngay_sinh.Name = "m_txt_ngay_sinh";
            this.m_txt_ngay_sinh.Size = new System.Drawing.Size(221, 20);
            this.m_txt_ngay_sinh.TabIndex = 6;
            // 
            // m_txt_ho_ten
            // 
            this.m_txt_ho_ten.Location = new System.Drawing.Point(129, 123);
            this.m_txt_ho_ten.Name = "m_txt_ho_ten";
            this.m_txt_ho_ten.Size = new System.Drawing.Size(221, 20);
            this.m_txt_ho_ten.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 231);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(429, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "NGÀY SINH";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "HỌ VÀ TÊN";
            // 
            // m_txt_so_bao_danh
            // 
            this.m_txt_so_bao_danh.Location = new System.Drawing.Point(129, 67);
            this.m_txt_so_bao_danh.Name = "m_txt_so_bao_danh";
            this.m_txt_so_bao_danh.Size = new System.Drawing.Size(221, 20);
            this.m_txt_so_bao_danh.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SỐ BÁO DANH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_luu);
            this.panelControl1.Controls.Add(this.m_cmd_thoat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 252);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(804, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(562, 2);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(120, 33);
            this.m_cmd_luu.TabIndex = 0;
            this.m_cmd_luu.Text = "Lưu dữ liệu";
            this.m_cmd_luu.Click += new System.EventHandler(this.m_cmd_luu_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_thoat.Image")));
            this.m_cmd_thoat.Location = new System.Drawing.Point(682, 2);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(120, 33);
            this.m_cmd_thoat.TabIndex = 1;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(804, 289);
            this.panelControl2.TabIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Khu vực";
            this.gridColumn1.FieldName = "MA_KHU_VUC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đối tượng";
            this.gridColumn2.FieldName = "MA_DOI_TUONG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ưu tiên";
            this.gridColumn3.FieldName = "MA_UU_TIEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // F140_HO_SO_THI_SINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 289);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "F140_HO_SO_THI_SINH";
            this.Text = "THÔNG TIN CHI TIẾT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_uu_tien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_doi_tuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_khu_vuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox m_txt_so_bao_danh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_khu_vuc;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker m_txt_ngay_sinh;
        private System.Windows.Forms.TextBox m_txt_ho_ten;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_uu_tien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_doi_tuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}

