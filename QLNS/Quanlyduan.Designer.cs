namespace QLNS
{
    partial class Quanlyduan
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
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.txtTenDA = new System.Windows.Forms.TextBox();
			this.txtMotaDA = new System.Windows.Forms.TextBox();
			this.txtSoNVDA = new System.Windows.Forms.TextBox();
			this.txtMaDA = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvDuAn = new System.Windows.Forms.DataGridView();
			this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sonv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.motapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.Location = new System.Drawing.Point(7, 6);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(78, 32);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Trở lại";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(509, 437);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Copyright by NguyenVanChuong 7/2019";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnthem);
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Controls.Add(this.txtTenDA);
			this.panel2.Controls.Add(this.txtMotaDA);
			this.panel2.Controls.Add(this.txtSoNVDA);
			this.panel2.Controls.Add(this.txtMaDA);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.label18);
			this.panel2.Controls.Add(this.label19);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(578, 244);
			this.panel2.TabIndex = 1;
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Image = global::QLNS.Properties.Resources.iconfinder_Remove_278742;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.Location = new System.Drawing.Point(447, 197);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(66, 27);
			this.btnXoa.TabIndex = 0;
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
			this.btnSua.Location = new System.Drawing.Point(376, 199);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(66, 27);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnthem
			// 
			this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnthem.Image = global::QLNS.Properties.Resources.iconfinder_Stock_Index_Up_278812;
			this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnthem.Location = new System.Drawing.Point(305, 199);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(66, 27);
			this.btnthem.TabIndex = 12;
			this.btnthem.Text = "Thêm";
			this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSearch.Image = global::QLNS.Properties.Resources.iconfinder_Zoom_In_278882;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.Location = new System.Drawing.Point(68, 197);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(98, 27);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSearch.Location = new System.Drawing.Point(172, 198);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(95, 24);
			this.txtSearch.TabIndex = 7;
			// 
			// txtTenDA
			// 
			this.txtTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTenDA.Location = new System.Drawing.Point(127, 138);
			this.txtTenDA.Name = "txtTenDA";
			this.txtTenDA.Size = new System.Drawing.Size(140, 24);
			this.txtTenDA.TabIndex = 5;
			// 
			// txtMotaDA
			// 
			this.txtMotaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMotaDA.Location = new System.Drawing.Point(365, 138);
			this.txtMotaDA.Name = "txtMotaDA";
			this.txtMotaDA.Size = new System.Drawing.Size(148, 24);
			this.txtMotaDA.TabIndex = 11;
			// 
			// txtSoNVDA
			// 
			this.txtSoNVDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSoNVDA.Location = new System.Drawing.Point(365, 77);
			this.txtSoNVDA.Name = "txtSoNVDA";
			this.txtSoNVDA.Size = new System.Drawing.Size(148, 24);
			this.txtSoNVDA.TabIndex = 9;
			// 
			// txtMaDA
			// 
			this.txtMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMaDA.Location = new System.Drawing.Point(127, 77);
			this.txtMaDA.Name = "txtMaDA";
			this.txtMaDA.Size = new System.Drawing.Size(140, 24);
			this.txtMaDA.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.Location = new System.Drawing.Point(65, 141);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(57, 18);
			this.label17.TabIndex = 4;
			this.label17.Text = "Tên DA";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label18.Location = new System.Drawing.Point(65, 77);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(53, 18);
			this.label18.TabIndex = 2;
			this.label18.Text = "Mã DA";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label19.Location = new System.Drawing.Point(303, 141);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(46, 18);
			this.label19.TabIndex = 10;
			this.label19.Text = "Mô tả";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label20.Location = new System.Drawing.Point(303, 80);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(51, 18);
			this.label20.TabIndex = 8;
			this.label20.Text = "Số NV";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label21.Location = new System.Drawing.Point(184, 18);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(146, 24);
			this.label21.TabIndex = 1;
			this.label21.Text = "Quản lý Dự Án";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvDuAn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(103, 253);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(578, 155);
			this.panel3.TabIndex = 2;
			// 
			// dgvDuAn
			// 
			this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapb,
            this.tenpb,
            this.sonv,
            this.motapb});
			this.dgvDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDuAn.Location = new System.Drawing.Point(0, 0);
			this.dgvDuAn.Name = "dgvDuAn";
			this.dgvDuAn.Size = new System.Drawing.Size(578, 155);
			this.dgvDuAn.TabIndex = 0;
			this.dgvDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellClick);
			// 
			// mapb
			// 
			this.mapb.DataPropertyName = "id_Da";
			this.mapb.HeaderText = "Mã DA";
			this.mapb.Name = "mapb";
			this.mapb.Width = 50;
			// 
			// tenpb
			// 
			this.tenpb.DataPropertyName = "name_Da";
			this.tenpb.HeaderText = "Tên DA";
			this.tenpb.Name = "tenpb";
			this.tenpb.Width = 200;
			// 
			// sonv
			// 
			this.sonv.DataPropertyName = "sonv_Da";
			this.sonv.HeaderText = "Số nhân viên";
			this.sonv.Name = "sonv";
			// 
			// motapb
			// 
			this.motapb.DataPropertyName = "mota_Da";
			this.motapb.HeaderText = "Mô tả";
			this.motapb.Name = "motapb";
			this.motapb.Width = 300;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(103, 414);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(578, 44);
			this.panel4.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.Image = global::QLNS.Properties.Resources.iconfinder_Undo_278852;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Trở lại";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(94, 244);
			this.panel1.TabIndex = 0;
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
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// Quanlyduan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label1);
			this.Name = "Quanlyduan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý dự án";
			this.Load += new System.EventHandler(this.Quanlyduan_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMotaDA;
        private System.Windows.Forms.TextBox txtSoNVDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonv;
        private System.Windows.Forms.DataGridViewTextBoxColumn motapb;
    }
}