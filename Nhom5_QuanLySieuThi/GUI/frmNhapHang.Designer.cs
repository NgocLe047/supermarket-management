namespace Nhom5_QuanLySieuThi.GUI
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchTen = new System.Windows.Forms.PictureBox();
            this.btnSearchMa = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchLoai = new System.Windows.Forms.PictureBox();
            this.cboNhaCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGVCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtGVHangHoa = new System.Windows.Forms.DataGridView();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePickerNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dTGVHangHoa1 = new System.Windows.Forms.DataGridView();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.cboSoPhieuNhap = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.txtSoLuongNhap = new TKControl.NumberTextBox();
            this.txtDonGia = new TKControl.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTGVHangHoa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchTen
            // 
            this.btnSearchTen.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTen.Image")));
            this.btnSearchTen.Location = new System.Drawing.Point(1286, 334);
            this.btnSearchTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTen.Name = "btnSearchTen";
            this.btnSearchTen.Size = new System.Drawing.Size(34, 37);
            this.btnSearchTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchTen.TabIndex = 210;
            this.btnSearchTen.TabStop = false;
            this.btnSearchTen.Click += new System.EventHandler(this.btnSearchTen_Click_1);
            // 
            // btnSearchMa
            // 
            this.btnSearchMa.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMa.Image")));
            this.btnSearchMa.Location = new System.Drawing.Point(664, 240);
            this.btnSearchMa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMa.Name = "btnSearchMa";
            this.btnSearchMa.Size = new System.Drawing.Size(34, 37);
            this.btnSearchMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchMa.TabIndex = 209;
            this.btnSearchMa.TabStop = false;
            this.btnSearchMa.Click += new System.EventHandler(this.btnSearchMa_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(912, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 204;
            this.label3.Text = "Mã Hàng Hóa :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(295, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 205;
            this.label2.Text = "Số Phiếu Nhập :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(295, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 211;
            this.label6.Text = "Số Lượng Nhập  :";
            // 
            // btnSearchLoai
            // 
            this.btnSearchLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLoai.Image")));
            this.btnSearchLoai.Location = new System.Drawing.Point(1286, 243);
            this.btnSearchLoai.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchLoai.Name = "btnSearchLoai";
            this.btnSearchLoai.Size = new System.Drawing.Size(34, 37);
            this.btnSearchLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchLoai.TabIndex = 215;
            this.btnSearchLoai.TabStop = false;
            this.btnSearchLoai.Click += new System.EventHandler(this.btnSearchLoai_Click_1);
            // 
            // cboNhaCC
            // 
            this.cboNhaCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNhaCC.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaCC.FormattingEnabled = true;
            this.cboNhaCC.Location = new System.Drawing.Point(914, 240);
            this.cboNhaCC.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Size = new System.Drawing.Size(350, 37);
            this.cboNhaCC.TabIndex = 214;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(910, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 213;
            this.label5.Text = "Nhà cung cấp :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtGVCTPhieuNhap);
            this.panel1.Controls.Add(this.dtGVHangHoa);
            this.panel1.Location = new System.Drawing.Point(112, 584);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 415);
            this.panel1.TabIndex = 216;
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
            this.dtGVCTPhieuNhap.Size = new System.Drawing.Size(782, 415);
            this.dtGVCTPhieuNhap.TabIndex = 3;
            this.dtGVCTPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVCTPhieuNhap_CellClick_1);
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
            this.dtGVHangHoa.Size = new System.Drawing.Size(782, 415);
            this.dtGVHangHoa.TabIndex = 2;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhapHang.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(1424, 135);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(158, 76);
            this.btnNhapHang.TabIndex = 217;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.btnBack.TabIndex = 218;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // dateTimePickerNgaySX
            // 
            this.dateTimePickerNgaySX.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySX.Location = new System.Drawing.Point(299, 240);
            this.dateTimePickerNgaySX.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgaySX.Name = "dateTimePickerNgaySX";
            this.dateTimePickerNgaySX.Size = new System.Drawing.Size(347, 40);
            this.dateTimePickerNgaySX.TabIndex = 220;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(295, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 219;
            this.label8.Text = "Ngày Tạo Phiếu :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(911, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 221;
            this.label1.Text = "Đơn Giá  :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dTGVHangHoa1);
            this.panel2.Location = new System.Drawing.Point(914, 584);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 415);
            this.panel2.TabIndex = 217;
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
            this.dTGVHangHoa1.Size = new System.Drawing.Size(668, 415);
            this.dTGVHangHoa1.TabIndex = 2;
            this.dTGVHangHoa1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTGVHangHoa1_CellContentClick);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaPN.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSuaPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPN.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPN.ForeColor = System.Drawing.Color.White;
            this.btnSuaPN.Location = new System.Drawing.Point(1424, 233);
            this.btnSuaPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(158, 76);
            this.btnSuaPN.TabIndex = 223;
            this.btnSuaPN.Text = "Sửa hàng hóa";
            this.btnSuaPN.UseVisualStyleBackColor = false;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click_1);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaPN.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoaPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPN.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPN.ForeColor = System.Drawing.Color.White;
            this.btnXoaPN.Location = new System.Drawing.Point(1424, 334);
            this.btnXoaPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(158, 76);
            this.btnXoaPN.TabIndex = 224;
            this.btnXoaPN.Text = "Xóa hàng hóa";
            this.btnXoaPN.UseVisualStyleBackColor = false;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click_1);
            // 
            // btnThemPN
            // 
            this.btnThemPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemPN.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThemPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPN.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPN.ForeColor = System.Drawing.Color.White;
            this.btnThemPN.Location = new System.Drawing.Point(517, 95);
            this.btnThemPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(181, 61);
            this.btnThemPN.TabIndex = 225;
            this.btnThemPN.Text = "Tạo phiếu";
            this.btnThemPN.UseVisualStyleBackColor = false;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // cboSoPhieuNhap
            // 
            this.cboSoPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSoPhieuNhap.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoPhieuNhap.FormattingEnabled = true;
            this.cboSoPhieuNhap.Location = new System.Drawing.Point(299, 340);
            this.cboSoPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.cboSoPhieuNhap.Name = "cboSoPhieuNhap";
            this.cboSoPhieuNhap.Size = new System.Drawing.Size(347, 37);
            this.cboSoPhieuNhap.TabIndex = 226;
            this.cboSoPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cboSoPhieuNhap_SelectedIndexChanged);
            this.cboSoPhieuNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSoPhieuNhap_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 543);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 229;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(898, 543);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 228;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLapPhieu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(728, 95);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(181, 61);
            this.btnLapPhieu.TabIndex = 231;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInPhieu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Location = new System.Drawing.Point(951, 95);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(181, 61);
            this.btnInPhieu.TabIndex = 235;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMaHang
            // 
            this.cboMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMaHang.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(914, 334);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(350, 37);
            this.cboMaHang.TabIndex = 236;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuongNhap.BackColor = System.Drawing.Color.White;
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongNhap.Location = new System.Drawing.Point(299, 443);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongNhap.Multiline = true;
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(347, 37);
            this.txtSoLuongNhap.TabIndex = 234;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(915, 443);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(350, 37);
            this.txtDonGia.TabIndex = 233;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1672, 1010);
            this.Controls.Add(this.cboMaHang);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cboSoPhieuNhap);
            this.Controls.Add(this.btnThemPN);
            this.Controls.Add(this.btnXoaPN);
            this.Controls.Add(this.btnSuaPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerNgaySX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchLoai);
            this.Controls.Add(this.cboNhaCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchTen);
            this.Controls.Add(this.btnSearchMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTGVHangHoa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSearchTen;
        private System.Windows.Forms.PictureBox btnSearchMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnSearchLoai;
        private System.Windows.Forms.ComboBox cboNhaCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dtGVHangHoa;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.DataGridView dtGVCTPhieuNhap;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dTGVHangHoa1;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.ComboBox cboSoPhieuNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLapPhieu;
        private TKControl.NumberTextBox txtDonGia;
        private TKControl.NumberTextBox txtSoLuongNhap;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.ComboBox cboMaHang;
    }
}