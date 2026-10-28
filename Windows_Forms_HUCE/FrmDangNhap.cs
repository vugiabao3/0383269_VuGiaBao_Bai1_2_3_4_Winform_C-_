using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class FrmDangNhap : Form
    {
        private int soLanSai = 0;

        public string TenDangNhap { get; private set; } = "";

        // Ma bam SHA-256 cua mat khau "123456"
        private static readonly byte[] MatKhauHash =
            SHA256.HashData(Encoding.UTF8.GetBytes("123456"));

        public FrmDangNhap()
        {
            InitializeComponent();

            // Nap thong tin da luu khi mo form
            chkGhiNho.Checked =
                Properties.Settings.Default.GhiNhoDangNhap;

            if (chkGhiNho.Checked)
            {
                txtUser.Text =
                    Properties.Settings.Default.TenDangNhap;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;

            if (user == "")
            {
                Canh_Bao("Vui long nhap ten dang nhap", txtUser);
                return;
            }

            if (pass == "")
            {
                Canh_Bao("Vui long nhap mat khau", txtPass);
                return;
            }

            // Bam mat khau vua nhap bang SHA-256
            byte[] passHash =
                SHA256.HashData(Encoding.UTF8.GetBytes(pass));

            // So sanh ma bam thay vi so sanh mat khau truc tiep
            bool dungMatKhau =
                CryptographicOperations.FixedTimeEquals(
                    passHash, MatKhauHash);

            if (user == "admin" && dungMatKhau)
            {
                TenDangNhap = user;

                // Luu hoac xoa thong tin ghi nho
                if (chkGhiNho.Checked)
                {
                    Properties.Settings.Default.TenDangNhap = user;
                    Properties.Settings.Default.GhiNhoDangNhap = true;
                }
                else
                {
                    Properties.Settings.Default.TenDangNhap = "";
                    Properties.Settings.Default.GhiNhoDangNhap = false;
                }

                Properties.Settings.Default.Save();

                DialogResult = DialogResult.OK;
                return;
            }

            soLanSai++;

            lblThongBao.Text =
                $"Sai ten dang nhap hoac mat khau ({soLanSai}/3)";

            txtPass.Clear();
            txtPass.Focus();

            if (soLanSai >= 3)
            {
                MessageBox.Show(
                    "Ban da nhap sai 3 lan. Ung dung se dong.",
                    "Dang nhap",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                DialogResult = DialogResult.Cancel;
            }
        }

        private void Canh_Bao(string noiDung, Control oCanNhap)
        {
            MessageBox.Show(
                noiDung,
                "Thong bao",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            oCanNhap.Focus();
        }

        private void chkHienMK_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkHienMK.Checked;
        }
    }
}
