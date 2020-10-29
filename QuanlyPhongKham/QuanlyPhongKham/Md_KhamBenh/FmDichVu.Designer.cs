namespace QuanlyPhongKham.Md_KhamBenh
{
    partial class FmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Chon = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btn_Chon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 44);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(353, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(97, 26);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Đóng";
            // 
            // btn_Chon
            // 
            this.btn_Chon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Chon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Chon.ImageOptions.Image")));
            this.btn_Chon.Location = new System.Drawing.Point(250, 8);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(97, 26);
            this.btn_Chon.TabIndex = 2;
            this.btn_Chon.Text = "Chọn ";
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 344);
            this.panel2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView4;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(749, 344);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colSoLuong,
            this.colDonGia,
            this.colTongTien,
            this.gridColumn12});
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.MultiSelect = true;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView4_CellValueChanged);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã DV";
            this.gridColumn8.FieldName = "MaDV";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Loại DV";
            this.gridColumn9.FieldName = "MaLoaiDV";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Diễn Giải";
            this.gridColumn10.FieldName = "DienGiai";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.DisplayFormat.FormatString = "#,#";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 5;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.DisplayFormat.FormatString = "#,#";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongTien.FieldName = "ThanhTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "Tổng ={0:#,#}")});
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Active";
            this.gridColumn12.FieldName = "Active";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // FmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmDichVu";
            this.Load += new System.EventHandler(this.FmDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_Chon;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
    }
}