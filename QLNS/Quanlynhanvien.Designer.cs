namespace QLNS
{
    partial class Quanlynhanvien
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
			this.cbxDuan = new System.Windows.Forms.ComboBox();
			this.cbxPhongban = new System.Windows.Forms.ComboBox();
			this.txtTenNv = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.txtDiachi = new System.Windows.Forms.TextBox();
			this.txtMaNv = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.lblMaDa = new System.Windows.Forms.Label();
			this.lblMaPb = new System.Windows.Forms.Label();
			this.lblLuong = new System.Windows.Forms.Label();
			this.lblNgaysinh = new System.Windows.Forms.Label();
			this.lblTenNv = new System.Windows.Forms.Label();
			this.lblMaNv = new System.Windows.Forms.Label();
			this.lblDiachi = new System.Windows.Forms.Label();
			this.lblTieude = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvNhanVien = new System.Windows.Forms.DataGridView();
			this.id_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nam_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.luong_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.qLNS = new QLNS.QLNS();
			this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pHONGBANTableAdapter = new QLNS.QLNSTableAdapters.PHONGBANTableAdapter();
			this.tableAdapterManager = new QLNS.QLNSTableAdapters.TableAdapterManager();
			this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dUANTableAdapter = new QLNS.QLNSTableAdapters.DUANTableAdapter();
			this.idDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sonvDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.motaDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLNS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(94, 244);
			this.panel1.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.Image = global::QLNS.Properties.Resources.iconfinder_Undo_278852;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.Location = new System.Drawing.Point(0, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(81, 32);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Trở lại";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnExportExcel);
			this.panel2.Controls.Add(this.btnreset);
			this.panel2.Controls.Add(this.dtpNgaysinh);
			this.panel2.Controls.Add(this.cbxDuan);
			this.panel2.Controls.Add(this.cbxPhongban);
			this.panel2.Controls.Add(this.txtTenNv);
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Controls.Add(this.txtLuong);
			this.panel2.Controls.Add(this.txtDiachi);
			this.panel2.Controls.Add(this.txtMaNv);
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnTim);
			this.panel2.Controls.Add(this.lblMaDa);
			this.panel2.Controls.Add(this.lblMaPb);
			this.panel2.Controls.Add(this.lblLuong);
			this.panel2.Controls.Add(this.lblNgaysinh);
			this.panel2.Controls.Add(this.lblTenNv);
			this.panel2.Controls.Add(this.lblMaNv);
			this.panel2.Controls.Add(this.lblDiachi);
			this.panel2.Controls.Add(this.lblTieude);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(578, 244);
			this.panel2.TabIndex = 1;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExportExcel.Image = global::QLNS.Properties.Resources.Logoexe;
			this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportExcel.Location = new System.Drawing.Point(440, 202);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(75, 31);
			this.btnExportExcel.TabIndex = 21;
			this.btnExportExcel.Text = "Xuất ";
			this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnreset
			// 
			this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnreset.Image = global::QLNS.Properties.Resources.iconfinder_Synchronize_278832;
			this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnreset.Location = new System.Drawing.Point(59, 202);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(82, 31);
			this.btnreset.TabIndex = 20;
			this.btnreset.Text = "Reset";
			this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			// 
			// dtpNgaysinh
			// 
			this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
			this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgaysinh.Location = new System.Drawing.Point(114, 123);
			this.dtpNgaysinh.Name = "dtpNgaysinh";
			this.dtpNgaysinh.Size = new System.Drawing.Size(151, 24);
			this.dtpNgaysinh.TabIndex = 6;
			// 
			// cbxDuan
			// 
			this.cbxDuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbxDuan.FormattingEnabled = true;
			this.cbxDuan.Location = new System.Drawing.Point(406, 156);
			this.cbxDuan.Name = "cbxDuan";
			this.cbxDuan.Size = new System.Drawing.Size(149, 26);
			this.cbxDuan.TabIndex = 16;
			this.cbxDuan.ValueMember = "id_Da";
			// 
			// cbxPhongban
			// 
			this.cbxPhongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbxPhongban.FormattingEnabled = true;
			this.cbxPhongban.Location = new System.Drawing.Point(406, 123);
			this.cbxPhongban.Name = "cbxPhongban";
			this.cbxPhongban.Size = new System.Drawing.Size(149, 26);
			this.cbxPhongban.TabIndex = 14;
			this.cbxPhongban.ValueMember = "id_Pb";
			// 
			// txtTenNv
			// 
			this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTenNv.Location = new System.Drawing.Point(114, 91);
			this.txtTenNv.Name = "txtTenNv";
			this.txtTenNv.Size = new System.Drawing.Size(149, 24);
			this.txtTenNv.TabIndex = 4;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSearch.Location = new System.Drawing.Point(137, 157);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(128, 24);
			this.txtSearch.TabIndex = 8;
			// 
			// txtLuong
			// 
			this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtLuong.Location = new System.Drawing.Point(406, 89);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(149, 24);
			this.txtLuong.TabIndex = 12;
			// 
			// txtDiachi
			// 
			this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtDiachi.Location = new System.Drawing.Point(406, 48);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(149, 24);
			this.txtDiachi.TabIndex = 10;
			// 
			// txtMaNv
			// 
			this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMaNv.Location = new System.Drawing.Point(114, 52);
			this.txtMaNv.Name = "txtMaNv";
			this.txtMaNv.Size = new System.Drawing.Size(149, 24);
			this.txtMaNv.TabIndex = 2;
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Image = global::QLNS.Properties.Resources.iconfinder_Remove_278742;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.Location = new System.Drawing.Point(346, 202);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 31);
			this.btnXoa.TabIndex = 19;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSua.Image = global::QLNS.Properties.Resources.iconfinder_Save_278762;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.Location = new System.Drawing.Point(256, 202);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 31);
			this.btnSua.TabIndex = 18;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.Image = global::QLNS.Properties.Resources.iconfinder_Stock_Index_Up_278812;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.Location = new System.Drawing.Point(158, 202);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(82, 31);
			this.btnThem.TabIndex = 17;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTim.Image = global::QLNS.Properties.Resources.iconfinder_Zoom_In_278882;
			this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTim.Location = new System.Drawing.Point(35, 153);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(96, 28);
			this.btnTim.TabIndex = 7;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// lblMaDa
			// 
			this.lblMaDa.AutoSize = true;
			this.lblMaDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMaDa.Location = new System.Drawing.Point(303, 159);
			this.lblMaDa.Name = "lblMaDa";
			this.lblMaDa.Size = new System.Drawing.Size(69, 18);
			this.lblMaDa.TabIndex = 15;
			this.lblMaDa.Text = "Mã dự án";
			// 
			// lblMaPb
			// 
			this.lblMaPb.AutoSize = true;
			this.lblMaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMaPb.Location = new System.Drawing.Point(302, 126);
			this.lblMaPb.Name = "lblMaPb";
			this.lblMaPb.Size = new System.Drawing.Size(102, 18);
			this.lblMaPb.TabIndex = 13;
			this.lblMaPb.Text = "Mã phòng ban";
			// 
			// lblLuong
			// 
			this.lblLuong.AutoSize = true;
			this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblLuong.Location = new System.Drawing.Point(303, 93);
			this.lblLuong.Name = "lblLuong";
			this.lblLuong.Size = new System.Drawing.Size(49, 18);
			this.lblLuong.TabIndex = 11;
			this.lblLuong.Text = "Lương";
			// 
			// lblNgaysinh
			// 
			this.lblNgaysinh.AutoSize = true;
			this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblNgaysinh.Location = new System.Drawing.Point(34, 125);
			this.lblNgaysinh.Name = "lblNgaysinh";
			this.lblNgaysinh.Size = new System.Drawing.Size(73, 18);
			this.lblNgaysinh.TabIndex = 5;
			this.lblNgaysinh.Text = "Ngày sinh";
			// 
			// lblTenNv
			// 
			this.lblTenNv.AutoSize = true;
			this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTenNv.Location = new System.Drawing.Point(36, 91);
			this.lblTenNv.Name = "lblTenNv";
			this.lblTenNv.Size = new System.Drawing.Size(52, 18);
			this.lblTenNv.TabIndex = 3;
			this.lblTenNv.Text = "Họ tên";
			// 
			// lblMaNv
			// 
			this.lblMaNv.AutoSize = true;
			this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMaNv.Location = new System.Drawing.Point(36, 52);
			this.lblMaNv.Name = "lblMaNv";
			this.lblMaNv.Size = new System.Drawing.Size(53, 18);
			this.lblMaNv.TabIndex = 1;
			this.lblMaNv.Text = "Mã NV";
			// 
			// lblDiachi
			// 
			this.lblDiachi.AutoSize = true;
			this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDiachi.Location = new System.Drawing.Point(303, 52);
			this.lblDiachi.Name = "lblDiachi";
			this.lblDiachi.Size = new System.Drawing.Size(53, 18);
			this.lblDiachi.TabIndex = 9;
			this.lblDiachi.Text = "Địa chỉ";
			// 
			// lblTieude
			// 
			this.lblTieude.AutoSize = true;
			this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTieude.Location = new System.Drawing.Point(200, 8);
			this.lblTieude.Name = "lblTieude";
			this.lblTieude.Size = new System.Drawing.Size(180, 24);
			this.lblTieude.TabIndex = 0;
			this.lblTieude.Text = "Quản lý nhân viên";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvNhanVien);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(103, 253);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(578, 155);
			this.panel3.TabIndex = 2;
			// 
			// dgvNhanVien
			// 
			this.dgvNhanVien.AllowUserToAddRows = false;
			this.dgvNhanVien.AllowUserToDeleteRows = false;
			this.dgvNhanVien.AutoGenerateColumns = false;
			this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Nv,
            this.nam_Nv,
            this.ngaysinh_Nv,
            this.diachi_Nv,
            this.luong_Nv,
            this.id_Pb,
            this.id_Da,
            this.idDaDataGridViewTextBoxColumn,
            this.nameDaDataGridViewTextBoxColumn,
            this.sonvDaDataGridViewTextBoxColumn,
            this.motaDaDataGridViewTextBoxColumn});
			this.dgvNhanVien.DataSource = this.dUANBindingSource;
			this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
			this.dgvNhanVien.Name = "dgvNhanVien";
			this.dgvNhanVien.ReadOnly = true;
			this.dgvNhanVien.Size = new System.Drawing.Size(578, 155);
			this.dgvNhanVien.TabIndex = 0;
			this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
			this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// id_Nv
			// 
			this.id_Nv.DataPropertyName = "id_Nv";
			this.id_Nv.HeaderText = "Mã NV";
			this.id_Nv.Name = "id_Nv";
			this.id_Nv.ReadOnly = true;
			this.id_Nv.Width = 70;
			// 
			// nam_Nv
			// 
			this.nam_Nv.DataPropertyName = "name_Nv";
			this.nam_Nv.HeaderText = "Họ Tên";
			this.nam_Nv.Name = "nam_Nv";
			this.nam_Nv.ReadOnly = true;
			// 
			// ngaysinh_Nv
			// 
			this.ngaysinh_Nv.DataPropertyName = "ngaysinh_Nv";
			this.ngaysinh_Nv.HeaderText = "Ngày sinh";
			this.ngaysinh_Nv.Name = "ngaysinh_Nv";
			this.ngaysinh_Nv.ReadOnly = true;
			this.ngaysinh_Nv.Width = 80;
			// 
			// diachi_Nv
			// 
			this.diachi_Nv.DataPropertyName = "diachi_Nv";
			this.diachi_Nv.HeaderText = "Địa chỉ";
			this.diachi_Nv.Name = "diachi_Nv";
			this.diachi_Nv.ReadOnly = true;
			this.diachi_Nv.Width = 80;
			// 
			// luong_Nv
			// 
			this.luong_Nv.DataPropertyName = "luong_Nv";
			this.luong_Nv.HeaderText = "Lương";
			this.luong_Nv.Name = "luong_Nv";
			this.luong_Nv.ReadOnly = true;
			this.luong_Nv.Width = 70;
			// 
			// id_Pb
			// 
			this.id_Pb.DataPropertyName = "id_Pb";
			this.id_Pb.HeaderText = "Mã PB";
			this.id_Pb.Name = "id_Pb";
			this.id_Pb.ReadOnly = true;
			this.id_Pb.Width = 65;
			// 
			// id_Da
			// 
			this.id_Da.DataPropertyName = "id_Da";
			this.id_Da.HeaderText = "Mã DA";
			this.id_Da.Name = "id_Da";
			this.id_Da.ReadOnly = true;
			this.id_Da.Width = 65;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(103, 414);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(578, 44);
			this.panel4.TabIndex = 3;
			// 
			// qLNS
			// 
			this.qLNS.DataSetName = "QLNS";
			this.qLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pHONGBANBindingSource
			// 
			this.pHONGBANBindingSource.DataMember = "PHONGBAN";
			this.pHONGBANBindingSource.DataSource = this.qLNS;
			// 
			// pHONGBANTableAdapter
			// 
			this.pHONGBANTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DANGNHAPTableAdapter = null;
			this.tableAdapterManager.DUANTableAdapter = this.dUANTableAdapter;
			this.tableAdapterManager.NHANVIENTableAdapter = null;
			this.tableAdapterManager.PHONGBANTableAdapter = this.pHONGBANTableAdapter;
			this.tableAdapterManager.UpdateOrder = QLNS.QLNSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// dUANBindingSource
			// 
			this.dUANBindingSource.DataMember = "DUAN";
			this.dUANBindingSource.DataSource = this.qLNS;
			// 
			// dUANTableAdapter
			// 
			this.dUANTableAdapter.ClearBeforeFill = true;
			// 
			// idDaDataGridViewTextBoxColumn
			// 
			this.idDaDataGridViewTextBoxColumn.DataPropertyName = "id_Da";
			this.idDaDataGridViewTextBoxColumn.HeaderText = "id_Da";
			this.idDaDataGridViewTextBoxColumn.Name = "idDaDataGridViewTextBoxColumn";
			this.idDaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDaDataGridViewTextBoxColumn
			// 
			this.nameDaDataGridViewTextBoxColumn.DataPropertyName = "name_Da";
			this.nameDaDataGridViewTextBoxColumn.HeaderText = "name_Da";
			this.nameDaDataGridViewTextBoxColumn.Name = "nameDaDataGridViewTextBoxColumn";
			this.nameDaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sonvDaDataGridViewTextBoxColumn
			// 
			this.sonvDaDataGridViewTextBoxColumn.DataPropertyName = "sonv_Da";
			this.sonvDaDataGridViewTextBoxColumn.HeaderText = "sonv_Da";
			this.sonvDaDataGridViewTextBoxColumn.Name = "sonvDaDataGridViewTextBoxColumn";
			this.sonvDaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// motaDaDataGridViewTextBoxColumn
			// 
			this.motaDaDataGridViewTextBoxColumn.DataPropertyName = "mota_Da";
			this.motaDaDataGridViewTextBoxColumn.HeaderText = "mota_Da";
			this.motaDaDataGridViewTextBoxColumn.Name = "motaDaDataGridViewTextBoxColumn";
			this.motaDaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Quanlynhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Quanlynhanvien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.Quanlynhanvien_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLNS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Da;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbxDuan;
        private System.Windows.Forms.ComboBox cbxPhongban;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnExportExcel;
		private QLNS qLNS;
		private System.Windows.Forms.BindingSource pHONGBANBindingSource;
		private QLNSTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
		private QLNSTableAdapters.TableAdapterManager tableAdapterManager;
		private QLNSTableAdapters.DUANTableAdapter dUANTableAdapter;
		private System.Windows.Forms.BindingSource dUANBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sonvDaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn motaDaDataGridViewTextBoxColumn;
	}
}