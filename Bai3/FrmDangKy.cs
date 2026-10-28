using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }
        static int TinhTuoi(DateTime ngaySinh)
        {
            DateTime homNay = DateTime.Today;
            int tuoi = homNay.Year - ngaySinh.Year;
            if (ngaySinh.Date > homNay.AddYears(-tuoi)) tuoi--; // chua den sinh nhat nam nay
            return tuoi;
        }
        private bool KiemTraHopLe()
        {
            errorProvider1.Clear();
            bool ok = true;
            if (!Regex.IsMatch(txtMaSV.Text.Trim(), @"^\d{6,10}$"))
            { errorProvider1.SetError(txtMaSV, "Ma SV gom 6-10 chu so"); ok = false; }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            { errorProvider1.SetError(txtHoTen, "Ho ten khong duoc de trong"); ok = false; }
            if (TinhTuoi(dtpNgaySinh.Value) < 17)
            {
                errorProvider1.SetError(dtpNgaySinh, "Sinh vien phai tu 17 tuoi tro len"); ok =
           false;
            }
            if (!rdoNam.Checked && !rdoNu.Checked)
            { errorProvider1.SetError(grpGioiTinh, "Chon gioi tinh"); ok = false; }
            if (cboLop.SelectedIndex < 0)
            { errorProvider1.SetError(cboLop, "Chon lop"); ok = false; }
            return ok;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;
            var soThich = grpSoThich.Controls.OfType<CheckBox>()
            .Where(c => c.Checked)
           .Select(c => c.Text);
            string dsSoThich = soThich.Any() ? string.Join(", ", soThich) : "Khong co";
            var sb = new StringBuilder();
            sb.AppendLine($"Ma SV : {txtMaSV.Text.Trim()}");
            sb.AppendLine($"Ho ten : {txtHoTen.Text.Trim()}");
            sb.AppendLine($"Ngay sinh: {dtpNgaySinh.Value:dd/MM/yyyy} (tuoi: {TinhTuoi(dtpNgaySinh.Value)})");
            sb.AppendLine($"Gioi tinh : {(rdoNam.Checked ? "Nam" : "Nu")}");
            sb.AppendLine($"Lop : {cboLop.SelectedItem}");
            sb.AppendLine($"So thich : {dsSoThich}");
            txtKetQua.Text = sb.ToString();
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xoa toan bo du lieu da nhap?", "Xac nhan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;
            txtMaSV.Clear(); txtHoTen.Clear(); txtKetQua.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            rdoNam.Checked = rdoNu.Checked = false;
            cboLop.SelectedIndex = -1;
            foreach (CheckBox c in grpSoThich.Controls.OfType<CheckBox>()) c.Checked = false;
            errorProvider1.Clear();
            txtMaSV.Focus();
        }
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // bo tieng bip
                dtpNgaySinh.Focus();
            }
        }
    }
}