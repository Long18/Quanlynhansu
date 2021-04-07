
namespace QuanLyNhanSu
{
	partial class QuanLyad
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.txtmatkhau = new System.Windows.Forms.TextBox();
			this.txtchucvu = new System.Windows.Forms.TextBox();
			this.txtSoNV = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvLogin = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ckbYes = new System.Windows.Forms.CheckBox();
			this.ckbNo = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnkiemtra = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 10;
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.Image = global::QuanLyNhanSu.Properties.Resources.iconfinder_Undo_278852;
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
			// panel2
			// 
			this.panel2.Controls.Add(this.btnkiemtra);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.ckbNo);
			this.panel2.Controls.Add(this.ckbYes);
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.txtmatkhau);
			this.panel2.Controls.Add(this.txtchucvu);
			this.panel2.Controls.Add(this.txtSoNV);
			this.panel2.Controls.Add(this.txtuser);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.label18);
			this.panel2.Controls.Add(this.label19);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 244);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Image = global::QuanLyNhanSu.Properties.Resources.iconfinder_Remove_278742;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.Location = new System.Drawing.Point(504, 172);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(66, 27);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSua.Image = global::QuanLyNhanSu.Properties.Resources.iconfinder_Save_278762;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.Location = new System.Drawing.Point(432, 172);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(66, 27);
			this.btnSua.TabIndex = 26;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtmatkhau.Location = new System.Drawing.Point(135, 109);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.Size = new System.Drawing.Size(140, 24);
			this.txtmatkhau.TabIndex = 18;
			// 
			// txtchucvu
			// 
			this.txtchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtchucvu.Location = new System.Drawing.Point(373, 109);
			this.txtchucvu.Name = "txtchucvu";
			this.txtchucvu.Size = new System.Drawing.Size(148, 24);
			this.txtchucvu.TabIndex = 24;
			// 
			// txtSoNV
			// 
			this.txtSoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSoNV.Location = new System.Drawing.Point(373, 48);
			this.txtSoNV.Name = "txtSoNV";
			this.txtSoNV.Size = new System.Drawing.Size(148, 24);
			this.txtSoNV.TabIndex = 22;
			// 
			// txtuser
			// 
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtuser.Location = new System.Drawing.Point(135, 48);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(140, 24);
			this.txtuser.TabIndex = 16;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.Location = new System.Drawing.Point(48, 112);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(71, 18);
			this.label17.TabIndex = 17;
			this.label17.Text = "Mật Khẩu";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label18.Location = new System.Drawing.Point(42, 54);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(77, 18);
			this.label18.TabIndex = 15;
			this.label18.Text = "Username";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label19.Location = new System.Drawing.Point(311, 112);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 18);
			this.label19.TabIndex = 23;
			this.label19.Text = "Chức Vụ";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label20.Location = new System.Drawing.Point(311, 51);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(51, 18);
			this.label20.TabIndex = 21;
			this.label20.Text = "Số NV";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label21.Location = new System.Drawing.Point(189, 8);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(172, 24);
			this.label21.TabIndex = 2;
			this.label21.Text = "Quản lý tài khoản";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvLogin);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(103, 253);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(594, 144);
			this.panel3.TabIndex = 2;
			// 
			// dgvLogin
			// 
			this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLogin.Location = new System.Drawing.Point(0, 0);
			this.dgvLogin.Name = "dgvLogin";
			this.dgvLogin.Size = new System.Drawing.Size(594, 144);
			this.dgvLogin.TabIndex = 0;
			this.dgvLogin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogin_CellContentClick);
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(103, 403);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(594, 44);
			this.panel4.TabIndex = 3;
			// 
			// ckbYes
			// 
			this.ckbYes.AutoSize = true;
			this.ckbYes.Location = new System.Drawing.Point(193, 172);
			this.ckbYes.Name = "ckbYes";
			this.ckbYes.Size = new System.Drawing.Size(39, 17);
			this.ckbYes.TabIndex = 27;
			this.ckbYes.Text = "Có";
			this.ckbYes.UseVisualStyleBackColor = true;
			// 
			// ckbNo
			// 
			this.ckbNo.AutoSize = true;
			this.ckbNo.Location = new System.Drawing.Point(238, 172);
			this.ckbNo.Name = "ckbNo";
			this.ckbNo.Size = new System.Drawing.Size(57, 17);
			this.ckbNo.TabIndex = 28;
			this.ckbNo.Text = "Không";
			this.ckbNo.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(42, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 18);
			this.label1.TabIndex = 29;
			this.label1.Text = "Kiểm tra hoạt động";
			// 
			// btnkiemtra
			// 
			this.btnkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnkiemtra.Image = global::QuanLyNhanSu.Properties.Resources.iconfinder_Stock_Index_Up_278812;
			this.btnkiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnkiemtra.Location = new System.Drawing.Point(314, 172);
			this.btnkiemtra.Name = "btnkiemtra";
			this.btnkiemtra.Size = new System.Drawing.Size(93, 27);
			this.btnkiemtra.TabIndex = 30;
			this.btnkiemtra.Text = "Kiểm Tra";
			this.btnkiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnkiemtra.UseVisualStyleBackColor = true;
			this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
			// 
			// QuanLyad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "QuanLyad";
			this.Text = "QuanLy";
			this.Load += new System.EventHandler(this.QuanLy_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dgvLogin;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.TextBox txtmatkhau;
		private System.Windows.Forms.TextBox txtchucvu;
		private System.Windows.Forms.TextBox txtSoNV;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ckbNo;
		private System.Windows.Forms.CheckBox ckbYes;
		private System.Windows.Forms.Button btnkiemtra;
	}
}