namespace QuanLyNhanSu
{
    partial class DangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
			this.btnDangnhap = new System.Windows.Forms.Button();
			this.btnDangky = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.lbtaikhoan = new System.Windows.Forms.Label();
			this.lbContent = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDangnhap
			// 
			this.btnDangnhap.BackColor = System.Drawing.Color.Transparent;
			this.btnDangnhap.Location = new System.Drawing.Point(79, 232);
			this.btnDangnhap.Name = "btnDangnhap";
			this.btnDangnhap.Size = new System.Drawing.Size(105, 36);
			this.btnDangnhap.TabIndex = 5;
			this.btnDangnhap.Text = "Đăng nhập";
			this.btnDangnhap.UseVisualStyleBackColor = false;
			this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
			// 
			// btnDangky
			// 
			this.btnDangky.BackColor = System.Drawing.Color.Transparent;
			this.btnDangky.Location = new System.Drawing.Point(218, 232);
			this.btnDangky.Name = "btnDangky";
			this.btnDangky.Size = new System.Drawing.Size(113, 36);
			this.btnDangky.TabIndex = 6;
			this.btnDangky.Text = "Đăng ký";
			this.btnDangky.UseVisualStyleBackColor = false;
			this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(76, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tài khoản:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(78, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật khẩu:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(177, 102);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(149, 26);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(177, 161);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(149, 26);
			this.txtPassword.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(142, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đăng nhập";
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Location = new System.Drawing.Point(328, 310);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(0, 20);
			this.lbTime.TabIndex = 7;
			this.lbTime.Visible = false;
			// 
			// lbtaikhoan
			// 
			this.lbtaikhoan.AutoSize = true;
			this.lbtaikhoan.Location = new System.Drawing.Point(361, 83);
			this.lbtaikhoan.Name = "lbtaikhoan";
			this.lbtaikhoan.Size = new System.Drawing.Size(0, 20);
			this.lbtaikhoan.TabIndex = 8;
			this.lbtaikhoan.Visible = false;
			// 
			// lbContent
			// 
			this.lbContent.AutoSize = true;
			this.lbContent.Location = new System.Drawing.Point(384, 223);
			this.lbContent.Name = "lbContent";
			this.lbContent.Size = new System.Drawing.Size(0, 20);
			this.lbContent.TabIndex = 9;
			this.lbContent.Visible = false;
			// 
			// DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(434, 361);
			this.Controls.Add(this.lbContent);
			this.Controls.Add(this.lbtaikhoan);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDangky);
			this.Controls.Add(this.btnDangnhap);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.Load += new System.EventHandler(this.DangNhap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label lbtaikhoan;
		private System.Windows.Forms.Label lbContent;
	}
}

