namespace Bai1
{
    partial class FrmDangNhap
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkHienMK = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lblThongBao = new Label();
            chkGhiNho = new CheckBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(125, 55);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(428, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(125, 133);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(428, 31);
            txtPass.TabIndex = 1;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Location = new Point(125, 198);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(154, 29);
            chkHienMK.TabIndex = 2;
            chkHienMK.Text = "Hiện Mật Khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(125, 297);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(162, 34);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập ";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(331, 297);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(46, 247);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(99, 25);
            lblThongBao.TabIndex = 5;
            lblThongBao.Text = "Thông báo";
            // 
            // chkGhiNho
            // 
            chkGhiNho.AutoSize = true;
            chkGhiNho.Location = new Point(322, 198);
            chkGhiNho.Name = "chkGhiNho";
            chkGhiNho.Size = new Size(126, 29);
            chkGhiNho.TabIndex = 6;
            chkGhiNho.Text = "Ghi nhớ tôi";
            chkGhiNho.UseVisualStyleBackColor = true;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkGhiNho);
            Controls.Add(lblThongBao);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(chkHienMK);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkHienMK;
        private Button btnDangNhap;
        private Button btnThoat;
        private Label lblThongBao;
        private CheckBox chkGhiNho;
    }
}