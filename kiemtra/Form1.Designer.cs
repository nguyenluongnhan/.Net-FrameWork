namespace kiemtra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDBDataSet1 = new kiemtra.QLDBDataSet1();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDBDataSet = new kiemtra.QLDBDataSet();
            this.nhomTableAdapter = new kiemtra.QLDBDataSetTableAdapters.NhomTableAdapter();
            this.sinhVienTableAdapter = new kiemtra.QLDBDataSet1TableAdapters.SinhVienTableAdapter();
            this.gridViewNhom = new System.Windows.Forms.DataGridView();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.tenSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnThemNhom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnThenLienLac = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenGoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinhVien)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLDBDataSet1;
            // 
            // qLDBDataSet1
            // 
            this.qLDBDataSet1.DataSetName = "QLDBDataSet1";
            this.qLDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "Nhom";
            this.nhomBindingSource.DataSource = this.qLDBDataSet;
            // 
            // qLDBDataSet
            // 
            this.qLDBDataSet.DataSetName = "QLDBDataSet";
            this.qLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // gridViewNhom
            // 
            this.gridViewNhom.AutoGenerateColumns = false;
            this.gridViewNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.gridViewNhom.DataSource = this.nhomBindingSource;
            this.gridViewNhom.Location = new System.Drawing.Point(0, 28);
            this.gridViewNhom.Name = "gridViewNhom";
            this.gridViewNhom.Size = new System.Drawing.Size(256, 382);
            this.gridViewNhom.TabIndex = 0;
            this.gridViewNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewNhom_CellClick);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            // 
            // gridViewSinhVien
            // 
            this.gridViewSinhVien.AutoGenerateColumns = false;
            this.gridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSinhVienDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.gridViewSinhVien.DataSource = this.sinhVienBindingSource;
            this.gridViewSinhVien.Location = new System.Drawing.Point(260, 28);
            this.gridViewSinhVien.Name = "gridViewSinhVien";
            this.gridViewSinhVien.Size = new System.Drawing.Size(510, 228);
            this.gridViewSinhVien.TabIndex = 1;
            this.gridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSinhVien_CellClick);
            // 
            // tenSinhVienDataGridViewTextBoxColumn
            // 
            this.tenSinhVienDataGridViewTextBoxColumn.DataPropertyName = "TenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenSinhVienDataGridViewTextBoxColumn.Name = "tenSinhVienDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnThemNhom,
            this.toolStripButton2,
            this.btnXoaNhom,
            this.toolStripButton3,
            this.btnThenLienLac,
            this.toolStripButton4,
            this.btnXoaLienLac,
            this.txtTimKiem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(72, 22);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(62, 22);
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // btnThenLienLac
            // 
            this.btnThenLienLac.Name = "btnThenLienLac";
            this.btnThenLienLac.Size = new System.Drawing.Size(77, 22);
            this.btnThenLienLac.Text = "Thêm liên lạc";
            this.btnThenLienLac.Click += new System.EventHandler(this.btnThenLienLac_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(67, 22);
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 25);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TimKiemS);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên gọi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // lbTenGoi
            // 
            this.lbTenGoi.AutoSize = true;
            this.lbTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGoi.Location = new System.Drawing.Point(391, 274);
            this.lbTenGoi.Name = "lbTenGoi";
            this.lbTenGoi.Size = new System.Drawing.Size(0, 26);
            this.lbTenGoi.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSoDienThoai);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Controls.Add(this.lbTenGoi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.gridViewSinhVien);
            this.panel1.Controls.Add(this.gridViewNhom);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 413);
            this.panel1.TabIndex = 0;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(395, 382);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(0, 17);
            this.lbSoDienThoai.TabIndex = 14;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(396, 347);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 17);
            this.lbEmail.TabIndex = 13;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(397, 313);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 17);
            this.lbDiaChi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 439);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - NGUYỄN LƯƠNG NHÂN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinhVien)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDBDataSet qLDBDataSet;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private QLDBDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private QLDBDataSet1 qLDBDataSet1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLDBDataSet1TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridView gridViewNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridViewSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel btnThemNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel btnXoaNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel btnThenLienLac;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel btnXoaLienLac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTenGoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

