
namespace Nhom5_QuanLySieuThi.GUI
{
    partial class frmQLHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHangHoa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGVHangHoa = new System.Windows.Forms.DataGridView();
            this.db_productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.btnSearchMa = new System.Windows.Forms.PictureBox();
            this.btnSearchTen = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnSearchLoai = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePickerNgaySX = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHSD = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new TKControl.NumberTextBox();
            this.txtSoLuongTon = new TKControl.NumberTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtGVHangHoa);
            this.panel1.Location = new System.Drawing.Point(240, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 424);
            this.panel1.TabIndex = 161;
            // 
            // dtGVHangHoa
            // 
            this.dtGVHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVHangHoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.dtGVHangHoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGVHangHoa.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtGVHangHoa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVHangHoa.RowTemplate.Height = 35;
            this.dtGVHangHoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGVHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVHangHoa.Size = new System.Drawing.Size(1216, 424);
            this.dtGVHangHoa.TabIndex = 2;
            this.dtGVHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHangHoa_CellContentClick_1);
            // 
            // db_productBindingSource
            // 
            this.db_productBindingSource.DataMember = "db_product";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHang.BackColor = System.Drawing.Color.White;
            this.txtMaHang.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.ForeColor = System.Drawing.Color.Black;
            this.txtMaHang.Location = new System.Drawing.Point(301, 115);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(352, 37);
            this.txtMaHang.TabIndex = 190;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(297, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 188;
            this.label2.Text = "Mã Hàng Hóa :";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHang.BackColor = System.Drawing.Color.White;
            this.txtTenHang.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenHang.Location = new System.Drawing.Point(301, 203);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(352, 37);
            this.txtTenHang.TabIndex = 189;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(297, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 187;
            this.label3.Text = "Tên Hàng Hóa :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(298, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 192;
            this.label4.Text = "Đơn Vị Tính :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(297, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 191;
            this.label1.Text = "Đơn Giá :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(790, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 196;
            this.label6.Text = "Số Lượng Tồn  :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(790, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 195;
            this.label5.Text = "Loại Hàng :";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1424, 124);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 76);
            this.btnThem.TabIndex = 198;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1424, 229);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(158, 76);
            this.btnSua.TabIndex = 199;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(794, 298);
            this.cboLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(352, 37);
            this.cboLoaiHang.TabIndex = 201;
            this.cboLoaiHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLoaiHang_KeyPress);
            // 
            // btnSearchMa
            // 
            this.btnSearchMa.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMa.Image")));
            this.btnSearchMa.Location = new System.Drawing.Point(657, 115);
            this.btnSearchMa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMa.Name = "btnSearchMa";
            this.btnSearchMa.Size = new System.Drawing.Size(34, 37);
            this.btnSearchMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchMa.TabIndex = 202;
            this.btnSearchMa.TabStop = false;
            this.btnSearchMa.Click += new System.EventHandler(this.btnSearchMa_Click_1);
            // 
            // btnSearchTen
            // 
            this.btnSearchTen.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTen.Image")));
            this.btnSearchTen.Location = new System.Drawing.Point(657, 203);
            this.btnSearchTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTen.Name = "btnSearchTen";
            this.btnSearchTen.Size = new System.Drawing.Size(34, 37);
            this.btnSearchTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchTen.TabIndex = 203;
            this.btnSearchTen.TabStop = false;
            this.btnSearchTen.Click += new System.EventHandler(this.btnSearchTen_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(790, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 205;
            this.label8.Text = "Ngày Sản Xuất :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(790, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 204;
            this.label7.Text = "HSD :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(298, 445);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 208;
            this.label9.Text = "Nhà Cung Cấp :";
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Palatino Linotype", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(302, 485);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(352, 37);
            this.cboNCC.TabIndex = 209;
            this.cboNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNCC_KeyPress);
            // 
            // btnSearchLoai
            // 
            this.btnSearchLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLoai.Image")));
            this.btnSearchLoai.Location = new System.Drawing.Point(1150, 298);
            this.btnSearchLoai.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchLoai.Name = "btnSearchLoai";
            this.btnSearchLoai.Size = new System.Drawing.Size(34, 37);
            this.btnSearchLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchLoai.TabIndex = 210;
            this.btnSearchLoai.TabStop = false;
            this.btnSearchLoai.Click += new System.EventHandler(this.btnSearchLoai_Click_1);
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
            this.btnBack.TabIndex = 211;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // dateTimePickerNgaySX
            // 
            this.dateTimePickerNgaySX.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySX.Location = new System.Drawing.Point(794, 115);
            this.dateTimePickerNgaySX.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgaySX.Name = "dateTimePickerNgaySX";
            this.dateTimePickerNgaySX.Size = new System.Drawing.Size(352, 40);
            this.dateTimePickerNgaySX.TabIndex = 212;
            // 
            // dateTimePickerHSD
            // 
            this.dateTimePickerHSD.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHSD.Location = new System.Drawing.Point(794, 200);
            this.dateTimePickerHSD.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHSD.Name = "dateTimePickerHSD";
            this.dateTimePickerHSD.Size = new System.Drawing.Size(352, 40);
            this.dateTimePickerHSD.TabIndex = 213;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 532);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 231;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDVT.BackColor = System.Drawing.Color.White;
            this.txtDVT.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.ForeColor = System.Drawing.Color.Black;
            this.txtDVT.Location = new System.Drawing.Point(301, 296);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDVT.Multiline = true;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(352, 37);
            this.txtDVT.TabIndex = 235;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(301, 386);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(352, 37);
            this.txtDonGia.TabIndex = 234;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuongTon.BackColor = System.Drawing.Color.White;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongTon.Location = new System.Drawing.Point(794, 386);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongTon.Multiline = true;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(352, 37);
            this.txtSoLuongTon.TabIndex = 233;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1424, 334);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(158, 76);
            this.btnLuu.TabIndex = 236;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQLHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1672, 1010);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerHSD);
            this.Controls.Add(this.dateTimePickerNgaySX);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchLoai);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchTen);
            this.Controls.Add(this.btnSearchMa);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQLHangHoa";
            this.Text = "a";
            this.Load += new System.EventHandler(this.frmQLHangHoa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource db_productBindingSource;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dtGVHangHoa;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.PictureBox btnSearchMa;
        private System.Windows.Forms.PictureBox btnSearchTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.PictureBox btnSearchLoai;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySX;
        private System.Windows.Forms.DateTimePicker dateTimePickerHSD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TKControl.NumberTextBox txtSoLuongTon;
        private TKControl.NumberTextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Button btnLuu;
    }
}