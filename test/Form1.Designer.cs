namespace Windows_Forms_HUCE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Hai Bà Trưng");
            TreeNode treeNode2 = new TreeNode("Node2");
            TreeNode treeNode3 = new TreeNode("Hà Nội", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Hải Hậu");
            TreeNode treeNode5 = new TreeNode("Hải Xuân");
            TreeNode treeNode6 = new TreeNode("Nam Định", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Bà Rịa");
            TreeNode treeNode8 = new TreeNode("Sài Gòn");
            TreeNode treeNode9 = new TreeNode("Hồ Chí Minh", new TreeNode[] { treeNode7, treeNode8 });
            ListViewItem listViewItem1 = new ListViewItem("Tên file");
            ListViewItem listViewItem2 = new ListViewItem("Size");
            ListViewItem listViewItem3 = new ListViewItem("Kiểu file");
            ListViewItem listViewItem4 = new ListViewItem("Ngày tháng ");
            lblHoTen = new Label();
            lblTuoi = new Label();
            lblGioiTinh = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtTuoi = new TextBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            btnLuu = new Button();
            btnXoa = new Button();
            ckb = new CheckBox();
            clbMonhoc = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            treeView1 = new TreeView();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(26, 80);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(99, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và Tên :";
            lblHoTen.Click += label1_Click;
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(26, 126);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(55, 25);
            lblTuoi.TabIndex = 1;
            lblTuoi.Text = "Tuổi :";
            lblTuoi.Click += label1_Click_1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(26, 180);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(83, 25);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 23);
            label3.Name = "label3";
            label3.Size = new Size(272, 25);
            label3.TabIndex = 3;
            label3.Text = "QUẢN LÝ THÔNG TIN CÁ NHÂN ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(339, 31);
            txtHoTen.TabIndex = 4;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(160, 123);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(339, 31);
            txtTuoi.TabIndex = 5;
            txtTuoi.TextChanged += txtTuoi_TextChanged;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(160, 180);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 6;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(333, 180);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 7;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            rdoNu.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(160, 764);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(147, 34);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(406, 764);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button2_Click;
            // 
            // ckb
            // 
            ckb.AutoSize = true;
            ckb.Cursor = Cursors.SizeNS;
            ckb.Location = new Point(160, 293);
            ckb.Name = "ckb";
            ckb.Size = new Size(121, 29);
            ckb.TabIndex = 10;
            ckb.Text = "checkBox1";
            ckb.UseVisualStyleBackColor = true;
            ckb.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // clbMonhoc
            // 
            clbMonhoc.FormattingEnabled = true;
            clbMonhoc.Items.AddRange(new object[] { "Giải tích ", "Đại số", "C#", "Cấu trúc dữ liệu giải thuật ", "Python" });
            clbMonhoc.Location = new Point(160, 410);
            clbMonhoc.Name = "clbMonhoc";
            clbMonhoc.Size = new Size(180, 144);
            clbMonhoc.TabIndex = 11;
            clbMonhoc.SelectedIndexChanged += clb_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 230);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 13;
            label1.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 284);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 14;
            label2.Text = "Vị trí làm việc";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 339);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 15;
            label4.Text = "Nơi làm việc";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "" });
            listBox1.Location = new Point(406, 410);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 336);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Chọn vị nơi làm ";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(638, 230);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Hai Bà Trưng";
            treeNode2.Name = "Bạch Mai";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Hà Nội";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Hải Hậu";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Hải Xuân";
            treeNode6.Name = "Nam Định";
            treeNode6.Text = "Nam Định";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Bà Rịa";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Sài Gòn";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Hồ Chí Minh";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6, treeNode9 });
            treeView1.Size = new Size(182, 275);
            treeView1.TabIndex = 18;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(638, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 140);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(160, 591);
            listView1.Name = "listView1";
            listView1.Size = new Size(442, 101);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 810);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(treeView1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(clbMonhoc);
            Controls.Add(ckb);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(txtTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblTuoi);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblTuoi;
        private Label lblGioiTinh;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtTuoi;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Button btnLuu;
        private Button btnXoa;
        private CheckBox ckb;
        private CheckedListBox clbMonhoc;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label4;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private TreeView treeView1;
        private PictureBox pictureBox1;
        private ListView listView1;
    }
}
