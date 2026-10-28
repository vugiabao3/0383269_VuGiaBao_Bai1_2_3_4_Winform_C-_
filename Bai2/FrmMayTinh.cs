using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai2
{
    public partial class FrmMayTinh : Form
    {
        private double soTruoc = 0; // ket qua / so da nhap truoc phep toan
        private string phepToan = ""; // phep toan dang cho: "+", "-", "x", "/"
        private bool nhapMoi = true; // true: chu so tiep theo se thay the noi dung man hinh 
        public FrmMayTinh()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += FrmMayTinh_KeyPress;
            this.KeyDown += FrmMayTinh_KeyDown;
        }
        private double DocMan()
        {
            return double.TryParse(txtMan.Text, NumberStyles.Float,
           CultureInfo.InvariantCulture, out double v) ? v : 0;
        }
        private void Nut_So_Click(object sender, EventArgs e)
        {
            string so = ((Button)sender).Text;
            if (nhapMoi || txtMan.Text == "0") txtMan.Text = so;
            else txtMan.Text += so;
            nhapMoi = false;
        }
        private void btnCham_Click(object sender, EventArgs e)
        {
            if (nhapMoi) { txtMan.Text = "0."; nhapMoi = false; }
            else if (!txtMan.Text.Contains('.')) txtMan.Text += ".";
        }
        private void Nut_PhepToan_Click(object sender, EventArgs e)
        {
            ChonPhepToan(((Button)sender).Text);
        }

        private void ChonPhepToan(string op)
        {
            if (phepToan != "" && !nhapMoi)
                Tinh();
            else
                soTruoc = DocMan();

            phepToan = op;
            nhapMoi = true;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            TinhBang();
        }

        private void TinhBang()
        {
            if (phepToan == "") return;

            Tinh();
            phepToan = "";
            nhapMoi = true;
        }
        private void Tinh()
        {
            double so2 = DocMan();
            switch (phepToan)
            {
                case "+": soTruoc += so2; break;
                case "-": soTruoc -= so2; break;
                case "x": soTruoc *= so2; break;
                case "/":
                    if (so2 == 0)
                    {
                        txtMan.Text = "Loi: chia cho 0";
                        DatLai();
                        return;
                    }
                    soTruoc /= so2;
                    break;
            }
            txtMan.Text = soTruoc.ToString(CultureInfo.InvariantCulture);
        }
        private void DatLai()
        {
            soTruoc = 0; phepToan = ""; nhapMoi = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DatLai();
            txtMan.Text = "0";
        }


        private void FrmMayTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // 1. Nhan phim so 0-9
            if (c >= '0' && c <= '9')
            {
                if (nhapMoi || txtMan.Text == "0")
                    txtMan.Text = c.ToString();
                else
                    txtMan.Text += c;

                nhapMoi = false;
                e.Handled = true;
            }

            // 2. Nhan dau cham thap phan
            else if (c == '.')
            {
                if (nhapMoi)
                {
                    txtMan.Text = "0.";
                    nhapMoi = false;
                }
                else if (!txtMan.Text.Contains('.'))
                {
                    txtMan.Text += ".";
                }

                e.Handled = true;
            }

            // 3. Nhan cac phim phep toan
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                string op = c == '*' ? "x" : c.ToString();

                ChonPhepToan(op);
                e.Handled = true;
            }
        }



        private void FrmMayTinh_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter: tinh ket qua
            if (e.KeyCode == Keys.Enter)
            {
                TinhBang();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            // Backspace: xoa mot ky tu
            else if (e.KeyCode == Keys.Back)
            {
                if (nhapMoi || txtMan.Text.StartsWith("Loi:"))
                {
                    txtMan.Text = "0";
                    nhapMoi = false;
                }
                else if (txtMan.Text.Length <= 1 ||
                         (txtMan.Text.Length == 2 && txtMan.Text.StartsWith("-")))
                {
                    txtMan.Text = "0";
                }
                else
                {
                    txtMan.Text = txtMan.Text.Substring(
                        0, txtMan.Text.Length - 1);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            // Esc: xoa toan bo
            else if (e.KeyCode == Keys.Escape)
            {
                DatLai();
                txtMan.Text = "0";

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

}

