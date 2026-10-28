using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_HUCE
{
    public partial class FrmChinh : Form
    {
        public FrmChinh(string tenDangNhap)
        {
            InitializeComponent();
            lblXinChao.Text = $"Xin chao, {tenDangNhap}!";
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Ban co chac muon dang xuat?", "Xac nhan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }

    }
}
