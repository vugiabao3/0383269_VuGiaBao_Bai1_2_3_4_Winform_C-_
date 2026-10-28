namespace Bai3
{
    partial class FrmDangKy
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
            components = new System.ComponentModel.Container();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNgaySinh = new DateTimePicker();
            grpGioiTinh = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label5 = new Label();
            grpSoThich = new GroupBox();
            chkDocSach = new CheckBox();
            chkAmNhac = new CheckBox();
            chkTheThao = new CheckBox();
            cboLop = new ComboBox();
            btnDangKy = new Button();
            btnNhapLai = new Button();
            label6 = new Label();
            txtKetQua = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            grpGioiTinh.SuspendLayout();
            grpSoThich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(174, 29);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(461, 31);
            txtMaSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(174, 78);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(461, 31);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 2;
            label1.Text = "Ma Sinh Vien ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 3;
            label2.Text = "Ho ten ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 144);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngay sinh ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 208);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(174, 139);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(300, 31);
            dtpNgaySinh.TabIndex = 6;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Location = new Point(31, 198);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(443, 71);
            grpGioiTinh.TabIndex = 7;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Gioi tinh";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(236, 30);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(46, 30);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(80, 29);
            rdoNam.TabIndex = 8;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam ";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 296);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 8;
            label5.Text = "Lop";
            // 
            // grpSoThich
            // 
            grpSoThich.Controls.Add(chkDocSach);
            grpSoThich.Controls.Add(chkAmNhac);
            grpSoThich.Controls.Add(chkTheThao);
            grpSoThich.Location = new Point(31, 352);
            grpSoThich.Name = "grpSoThich";
            grpSoThich.Size = new Size(590, 85);
            grpSoThich.TabIndex = 9;
            grpSoThich.TabStop = false;
            grpSoThich.Text = "So Thich";
            // 
            // chkDocSach
            // 
            chkDocSach.AutoSize = true;
            chkDocSach.Location = new Point(380, 30);
            chkDocSach.Name = "chkDocSach";
            chkDocSach.Size = new Size(110, 29);
            chkDocSach.TabIndex = 11;
            chkDocSach.Text = "Doc sach";
            chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkAmNhac
            // 
            chkAmNhac.AutoSize = true;
            chkAmNhac.Location = new Point(204, 30);
            chkAmNhac.Name = "chkAmNhac";
            chkAmNhac.Size = new Size(108, 29);
            chkAmNhac.TabIndex = 1;
            chkAmNhac.Text = "Am nhac";
            chkAmNhac.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            chkTheThao.AutoSize = true;
            chkTheThao.Location = new Point(46, 30);
            chkTheThao.Name = "chkTheThao";
            chkTheThao.Size = new Size(112, 29);
            chkTheThao.TabIndex = 0;
            chkTheThao.Text = "The thao ";
            chkTheThao.UseVisualStyleBackColor = true;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "69IT3", "45", "12" });
            cboLop.Location = new Point(174, 288);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(182, 33);
            cboLop.TabIndex = 10;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(77, 463);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 11;
            btnDangKy.Text = "Dang Ky";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(295, 463);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(112, 34);
            btnNhapLai.TabIndex = 12;
            btnNhapLai.Text = "Nhap Lai";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 534);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 13;
            label6.Text = "Ket qua dang ky";
            // 
            // txtKetQua
            // 
            txtKetQua.HideSelection = false;
            txtKetQua.Location = new Point(12, 581);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(753, 134);
            txtKetQua.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 741);
            Controls.Add(txtKetQua);
            Controls.Add(label6);
            Controls.Add(btnNhapLai);
            Controls.Add(btnDangKy);
            Controls.Add(cboLop);
            Controls.Add(grpSoThich);
            Controls.Add(label5);
            Controls.Add(grpGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Name = "FrmDangKy";
            Text = "FrmDangKy";
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            grpSoThich.ResumeLayout(false);
            grpSoThich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private GroupBox grpGioiTinh;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label5;
        private GroupBox grpSoThich;
        private ComboBox cboLop;
        private CheckBox chkDocSach;
        private CheckBox chkAmNhac;
        private CheckBox chkTheThao;
        private Button btnNhapLai;
        private Label label6;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;
        private Button btnDangKy;
    }
}