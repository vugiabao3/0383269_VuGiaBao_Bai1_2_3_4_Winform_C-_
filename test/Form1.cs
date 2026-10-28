namespace Windows_Forms_HUCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtTuoi.Clear();

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            txtHoTen.Focus();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!");
                txtHoTen.Focus();
                return;
            }

            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi < 0)
            {
                MessageBox.Show("Vui lòng nhập tuổi hợp lệ!");
                txtTuoi.Focus();
                return;
            }

            string gioiTinh = "";

            if (rdoNam.Checked)
                gioiTinh = "Nam";
            else if (rdoNu.Checked)
                gioiTinh = "Nữ";
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            MessageBox.Show(
                $"Họ tên: {hoTen}\n" +
                $"Tuổi: {tuoi}\n" +
                $"Giới tính: {gioiTinh}",
                "Thông tin cá nhân"
            );
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            // Chưa cần xử lý gì ở đây.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clb_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string? monhoc = string.Empty;
            //foreach(var item in clbMonhoc.CheckedItems)
            //{
            //    monhoc += item.ToString() + " , ";
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
