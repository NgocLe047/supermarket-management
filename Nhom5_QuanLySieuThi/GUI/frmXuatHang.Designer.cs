namespace Nhom5_QuanLySieuThi.GUI
{
    partial class frmXuatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            this.txtSoLuongXuat = new TKControl.NumberTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGVCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtGVHangHoa = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dTGVHangHoa1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTaoPXH = new System.Windows.Forms.DateTimePicker();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnSuaPX = new System.Windows.Forms.Button();
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.cboSoPhieuXuat = new System.Windows.Forms.ComboBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchLoai = new System.Windows.Forms.PictureBox();
            this.btnSearchTen = new System.Windows.Forms.PictureBox();
            this.btnSearchMa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTGVHangHoa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuongXuat.BackColor = System.Drawing.Color.White;
            this.txtSoLuongXuat.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongXuat.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongXuat.Location = new System.Drawing.Point(239, 371);
            this.txtSoLuongXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongXuat.Multiline = true;
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(376, 37);
            this.txtSoLuongXuat.TabIndex = 260;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(235, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 238;
            this.label2.Text = "Số Phiếu Xuất :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(828, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 237;
            this.label3.Text = "Mã Hàng Hóa :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(235, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 241;
            this.label6.Text = "Số Lượng Xuất  :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(829, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 242;
            this.label5.Text = "Loại Hàng :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLoaiHang.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(833, 204);
            this.cboLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(375, 37);
            this.cboLoaiHang.TabIndex = 243;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtGVCTPhieuNhap);
            this.panel1.Controls.Add(this.dtGVHangHoa);
            this.panel1.Location = new System.Drawing.Point(102, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 461);
            this.panel1.TabIndex = 245;
            // 
            // dtGVCTPhieuNhap
            // 
            this.dtGVCTPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVCTPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVCTPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVCTPhieuNhap.ColumnHeadersHeight = 40;
            this.dtGVCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVCTPhieuNhap.EnableHeadersVisualStyles = false;
            this.dtGVCTPhieuNhap.GridColor = System.Drawing.Color.White;
            this.dtGVCTPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dtGVCTPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVCTPhieuNhap.Name = "dtGVCTPhieuNhap";
            this.dtGVCTPhieuNhap.RowHeadersVisible = false;
            this.dtGVCTPhieuNhap.RowHeadersWidth = 51;
            this.dtGVCTPhieuNhap.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtGVCTPhieuNhap.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVCTPhieuNhap.RowTemplate.Height = 35;
            this.dtGVCTPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVCTPhieuNhap.Size = new System.Drawing.Size(710, 461);
            this.dtGVCTPhieuNhap.TabIndex = 3;
            this.dtGVCTPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVCTPhieuNhap_CellClick);
            // 
            // dtGVHangHoa
            // 
            this.dtGVHangHoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGVHangHoa.ColumnHeadersHeight = 40;
            this.dtGVHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVHangHoa.EnableHeadersVisualStyles = false;
            this.dtGVHangHoa.GridColor = System.Drawing.Color.White;
            this.dtGVHangHoa.Location = new System.Drawing.Point(0, 0);
            this.dtGVHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVHangHoa.Name = "dtGVHangHoa";
            this.dtGVHangHoa.RowHeadersVisible = false;
            this.dtGVHangHoa.RowHeadersWidth = 51;
            this.dtGVHangHoa.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtGVHangHoa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVHangHoa.RowTemplate.Height = 35;
            this.dtGVHangHoa.Size = new System.Drawing.Size(710, 461);
            this.dtGVHangHoa.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1457, 65);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 41);
            this.btnBack.TabIndex = 248;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuatHang.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHang.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHang.ForeColor = System.Drawing.Color.White;
            this.btnXuatHang.Location = new System.Drawing.Point(1424, 122);
            this.btnXuatHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(158, 76);
            this.btnXuatHang.TabIndex = 246;
            this.btnXuatHang.Text = "Xuất hàng";
            this.btnXuatHang.UseVisualStyleBackColor = false;
            this.btnXuatHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dTGVHangHoa1);
            this.panel2.Location = new System.Drawing.Point(833, 469);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 461);
            this.panel2.TabIndex = 247;
            // 
            // dTGVHangHoa1
            // 
            this.dTGVHangHoa1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dTGVHangHoa1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dTGVHangHoa1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dTGVHangHoa1.ColumnHeadersHeight = 40;
            this.dTGVHangHoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTGVHangHoa1.EnableHeadersVisualStyles = false;
            this.dTGVHangHoa1.GridColor = System.Drawing.Color.White;
            this.dTGVHangHoa1.Location = new System.Drawing.Point(0, 0);
            this.dTGVHangHoa1.Margin = new System.Windows.Forms.Padding(2);
            this.dTGVHangHoa1.Name = "dTGVHangHoa1";
            this.dTGVHangHoa1.RowHeadersVisible = false;
            this.dTGVHangHoa1.RowHeadersWidth = 51;
            this.dTGVHangHoa1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dTGVHangHoa1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTGVHangHoa1.RowTemplate.Height = 35;
            this.dTGVHangHoa1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dTGVHangHoa1.Size = new System.Drawing.Size(749, 461);
            this.dTGVHangHoa1.TabIndex = 2;
            this.dTGVHangHoa1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTGVHangHoa1_CellContentClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(234, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 249;
            this.label8.Text = "Ngày Tạo Phiếu :";
            // 
            // dateTimePickerNgayTaoPXH
            // 
            this.dateTimePickerNgayTaoPXH.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayTaoPXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTaoPXH.Location = new System.Drawing.Point(238, 204);
            this.dateTimePickerNgayTaoPXH.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgayTaoPXH.Name = "dateTimePickerNgayTaoPXH";
            this.dateTimePickerNgayTaoPXH.Size = new System.Drawing.Size(376, 40);
            this.dateTimePickerNgayTaoPXH.TabIndex = 250;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInPhieu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Location = new System.Drawing.Point(848, 55);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(181, 61);
            this.btnInPhieu.TabIndex = 261;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaPX.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSuaPX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPX.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPX.ForeColor = System.Drawing.Color.White;
            this.btnSuaPX.Location = new System.Drawing.Point(1424, 220);
            this.btnSuaPX.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPX.Name = "btnSuaPX";
            this.btnSuaPX.Size = new System.Drawing.Size(158, 76);
            this.btnSuaPX.TabIndex = 252;
            this.btnSuaPX.Text = "Sửa hàng hóa";
            this.btnSuaPX.UseVisualStyleBackColor = false;
            this.btnSuaPX.Click += new System.EventHandler(this.btnSuaPX_Click);
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaPX.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoaPX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPX.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPX.ForeColor = System.Drawing.Color.White;
            this.btnXoaPX.Location = new System.Drawing.Point(1424, 321);
            this.btnXoaPX.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(158, 76);
            this.btnXoaPX.TabIndex = 253;
            this.btnXoaPX.Text = "Xóa hàng hóa";
            this.btnXoaPX.UseVisualStyleBackColor = false;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnThemPX
            // 
            this.btnThemPX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemPX.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThemPX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPX.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPX.ForeColor = System.Drawing.Color.White;
            this.btnThemPX.Location = new System.Drawing.Point(397, 55);
            this.btnThemPX.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(181, 61);
            this.btnThemPX.TabIndex = 254;
            this.btnThemPX.Text = "Tạo Phiếu";
            this.btnThemPX.UseVisualStyleBackColor = false;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // cboSoPhieuXuat
            // 
            this.cboSoPhieuXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSoPhieuXuat.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoPhieuXuat.FormattingEnabled = true;
            this.cboSoPhieuXuat.Location = new System.Drawing.Point(239, 283);
            this.cboSoPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.cboSoPhieuXuat.Name = "cboSoPhieuXuat";
            this.cboSoPhieuXuat.Size = new System.Drawing.Size(376, 37);
            this.cboSoPhieuXuat.TabIndex = 255;
            this.cboSoPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cboSoPhieuXuat_SelectedIndexChanged);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLapPhieu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(622, 55);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(181, 61);
            this.btnLapPhieu.TabIndex = 258;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // cboMaHang
            // 
            this.cboMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMaHang.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(832, 283);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(375, 37);
            this.cboMaHang.TabIndex = 262;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 428);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 257;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(834, 428);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 256;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSearchLoai
            // 
            this.btnSearchLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLoai.Image")));
            this.btnSearchLoai.Location = new System.Drawing.Point(1232, 204);
            this.btnSearchLoai.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchLoai.Name = "btnSearchLoai";
            this.btnSearchLoai.Size = new System.Drawing.Size(34, 37);
            this.btnSearchLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchLoai.TabIndex = 244;
            this.btnSearchLoai.TabStop = false;
            this.btnSearchLoai.Click += new System.EventHandler(this.btnSearchLoai_Click);
            // 
            // btnSearchTen
            // 
            this.btnSearchTen.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTen.Image")));
            this.btnSearchTen.Location = new System.Drawing.Point(1232, 283);
            this.btnSearchTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTen.Name = "btnSearchTen";
            this.btnSearchTen.Size = new System.Drawing.Size(34, 37);
            this.btnSearchTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchTen.TabIndex = 240;
            this.btnSearchTen.TabStop = false;
            this.btnSearchTen.Click += new System.EventHandler(this.btnSearchTen_Click);
            // 
            // btnSearchMa
            // 
            this.btnSearchMa.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMa.Image")));
            this.btnSearchMa.Location = new System.Drawing.Point(641, 204);
            this.btnSearchMa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMa.Name = "btnSearchMa";
            this.btnSearchMa.Size = new System.Drawing.Size(34, 37);
            this.btnSearchMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchMa.TabIndex = 239;
            this.btnSearchMa.TabStop = false;
            this.btnSearchMa.Click += new System.EventHandler(this.btnSearchMa_Click);
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1672, 1010);
            this.Controls.Add(this.cboMaHang);
            this.Controls.Add(this.txtSoLuongXuat);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cboSoPhieuXuat);
            this.Controls.Add(this.btnThemPX);
            this.Controls.Add(this.btnXoaPX);
            this.Controls.Add(this.btnSuaPX);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.dateTimePickerNgayTaoPXH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXuatHang);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchLoai);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchTen);
            this.Controls.Add(this.btnSearchMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXuatHang";
            this.Text = "frmXuatHang";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTGVHangHoa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TKControl.NumberTextBox txtSoLuongXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnSearchMa;
        private System.Windows.Forms.PictureBox btnSearchTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.PictureBox btnSearchLoai;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dtGVCTPhieuNhap;
        public System.Windows.Forms.DataGridView dtGVHangHoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dTGVHangHoa1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTaoPXH;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnSuaPX;
        private System.Windows.Forms.Button btnXoaPX;
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.ComboBox cboSoPhieuXuat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label8;
    }
}