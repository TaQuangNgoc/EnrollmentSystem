﻿namespace EnrollmentSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_cmd_thong_tin = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nguyen_vong = new DevExpress.XtraBars.BarButtonItem();
            this.m_btn_report = new DevExpress.XtraBars.BarButtonItem();
            this.backUpButton = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAdmissionList = new DevExpress.XtraBars.BarButtonItem();
            this.buttonNonAdmissionList = new DevExpress.XtraBars.BarButtonItem();
            this.calculateButton = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdmissionList = new DevExpress.XtraBars.BarButtonItem();
            this.btnNonAdmissionList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.administrativeTab = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.administrativeGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.m_cmd_thong_tin,
            this.m_cmd_nguyen_vong,
            this.m_btn_report,
            this.backUpButton,
            this.buttonAdmissionList,
            this.buttonNonAdmissionList,
            this.calculateButton,
            this.btnAdmissionList,
            this.btnNonAdmissionList});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.administrativeTab});
            this.ribbon.Size = new System.Drawing.Size(993, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // m_cmd_thong_tin
            // 
            this.m_cmd_thong_tin.Caption = "THÔNG TIN THÍ SINH";
            this.m_cmd_thong_tin.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thong_tin.Glyph")));
            this.m_cmd_thong_tin.Id = 1;
            this.m_cmd_thong_tin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thong_tin.LargeGlyph")));
            this.m_cmd_thong_tin.LargeWidth = 100;
            this.m_cmd_thong_tin.Name = "m_cmd_thong_tin";
            this.m_cmd_thong_tin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_thong_tin_ItemClick);
            // 
            // m_cmd_nguyen_vong
            // 
            this.m_cmd_nguyen_vong.Caption = "THÔNG TIN NGUYỆN VỌNG";
            this.m_cmd_nguyen_vong.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguyen_vong.Glyph")));
            this.m_cmd_nguyen_vong.Id = 2;
            this.m_cmd_nguyen_vong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguyen_vong.LargeGlyph")));
            this.m_cmd_nguyen_vong.LargeWidth = 100;
            this.m_cmd_nguyen_vong.Name = "m_cmd_nguyen_vong";
            this.m_cmd_nguyen_vong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_nguyen_vong_ItemClick);
            // 
            // m_btn_report
            // 
            this.m_btn_report.Caption = "KẾT QUẢ CÁC NGÀNH";
            this.m_btn_report.Glyph = ((System.Drawing.Image)(resources.GetObject("m_btn_report.Glyph")));
            this.m_btn_report.Id = 3;
            this.m_btn_report.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_btn_report.LargeGlyph")));
            this.m_btn_report.LargeWidth = 100;
            this.m_btn_report.Name = "m_btn_report";
            this.m_btn_report.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_btn_report_ItemClick);
            // 
            // backUpButton
            // 
            this.backUpButton.Caption = "SAO LƯU";
            this.backUpButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.backUpButton.Glyph = ((System.Drawing.Image)(resources.GetObject("backUpButton.Glyph")));
            this.backUpButton.Id = 4;
            this.backUpButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("backUpButton.LargeGlyph")));
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.backUpButton_ItemClick);
            // 
            // buttonAdmissionList
            // 
            this.buttonAdmissionList.Id = 7;
            this.buttonAdmissionList.Name = "buttonAdmissionList";
            // 
            // buttonNonAdmissionList
            // 
            this.buttonNonAdmissionList.Id = 8;
            this.buttonNonAdmissionList.Name = "buttonNonAdmissionList";
            // 
            // calculateButton
            // 
            this.calculateButton.Caption = "CHẠY KẾT QUẢ";
            this.calculateButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.calculateButton.Glyph = ((System.Drawing.Image)(resources.GetObject("calculateButton.Glyph")));
            this.calculateButton.Id = 10;
            this.calculateButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("calculateButton.LargeGlyph")));
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.calculateButton_ItemClick);
            // 
            // btnAdmissionList
            // 
            this.btnAdmissionList.Caption = "DANH SÁCH TRÚNG TUYỂN";
            this.btnAdmissionList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdmissionList.Glyph")));
            this.btnAdmissionList.Id = 11;
            this.btnAdmissionList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAdmissionList.LargeGlyph")));
            this.btnAdmissionList.Name = "btnAdmissionList";
            this.btnAdmissionList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdmissionList_ItemClick);
            // 
            // btnNonAdmissionList
            // 
            this.btnNonAdmissionList.Caption = "DANH SÁCH KHÔNG TRÚNG TUYỂN";
            this.btnNonAdmissionList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNonAdmissionList.Glyph")));
            this.btnNonAdmissionList.Id = 12;
            this.btnNonAdmissionList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNonAdmissionList.LargeGlyph")));
            this.btnNonAdmissionList.Name = "btnNonAdmissionList";
            this.btnNonAdmissionList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNonAdmissionList_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỒ SƠ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_thong_tin);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_nguyen_vong);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.m_btn_report);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAdmissionList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNonAdmissionList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // administrativeTab
            // 
            this.administrativeTab.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.administrativeGroup});
            this.administrativeTab.Name = "administrativeTab";
            this.administrativeTab.Text = "QUẢN TRỊ";
            // 
            // administrativeGroup
            // 
            this.administrativeGroup.ItemLinks.Add(this.backUpButton);
            this.administrativeGroup.ItemLinks.Add(this.calculateButton);
            this.administrativeGroup.Name = "administrativeGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(993, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ thống quản lí tuyển sinh ĐHBKHN v2015";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem m_cmd_thong_tin;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nguyen_vong;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem m_btn_report;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem backUpButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage administrativeTab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup administrativeGroup;
        private DevExpress.XtraBars.BarButtonItem buttonAdmissionList;
        private DevExpress.XtraBars.BarButtonItem buttonNonAdmissionList;
        private DevExpress.XtraBars.BarButtonItem calculateButton;
        private DevExpress.XtraBars.BarButtonItem btnAdmissionList;
        private DevExpress.XtraBars.BarButtonItem btnNonAdmissionList;
    }
}