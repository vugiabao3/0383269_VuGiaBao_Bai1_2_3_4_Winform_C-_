namespace Bai4
{
    partial class FrmQuanLy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtMa = new TextBox();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            lstSinhVien = new ListBox();
            lblThongKe = new Label();
            btnLuu = new Button();
            btnMo = new Button();
            txtTim = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "MaSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Ho Ten ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Diem ";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 212);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 3;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(156, 212);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(289, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(419, 212);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(109, 30);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(521, 31);
            txtMa.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(109, 86);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(521, 31);
            txtHoTen.TabIndex = 8;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(109, 145);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(521, 31);
            txtDiem.TabIndex = 9;
            // 
            // lstSinhVien
            // 
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.ItemHeight = 25;
            lstSinhVien.Location = new Point(24, 332);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.Size = new Size(606, 229);
            lstSinhVien.TabIndex = 10;
            lstSinhVien.Click += lstSinhVien_SelectedIndexChanged;
            // 
            // lblThongKe
            // 
            lblThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblThongKe.AutoSize = true;
            lblThongKe.Location = new Point(24, 582);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(326, 25);
            lblThongKe.TabIndex = 11;
            lblThongKe.Text = "Tong so sinh vien :  |  Diem trung binh : ";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(24, 633);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnMo
            // 
            btnMo.Location = new Point(212, 633);
            btnMo.Name = "btnMo";
            btnMo.Size = new Size(112, 34);
            btnMo.TabIndex = 13;
            btnMo.Text = "Mo";
            btnMo.UseVisualStyleBackColor = true;
            btnMo.Click += btnMo_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(118, 272);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(512, 31);
            txtTim.TabIndex = 14;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 278);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 15;
            label4.Text = "Tim kiem ";
            // 
            // FrmQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 714);
            Controls.Add(label4);
            Controls.Add(txtTim);
            Controls.Add(btnMo);
            Controls.Add(btnLuu);
            Controls.Add(lblThongKe);
            Controls.Add(lstSinhVien);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(txtMa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQuanLy";
            Text = "FrmQuanLy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtMa;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private ListBox lstSinhVien;
        private Label lblThongKe;
        private Button btnLuu;
        private Button btnMo;
        private TextBox txtTim;
        private Label label4;
    }
}