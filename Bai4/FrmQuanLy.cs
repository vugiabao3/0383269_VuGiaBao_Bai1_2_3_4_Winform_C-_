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

namespace Bai4
{


    public partial class FrmQuanLy : Form
    {
        private readonly List<SinhVien> ds = new();
        // Danh sách sinh viên phù hợp với từ khóa tìm kiếm
        private List<SinhVien> LayDanhSachLoc()
        {
            string tuKhoa = txtTim.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
                return ds.ToList();

            return ds
                .Where(s => s.HoTen.Contains(
                    tuKhoa,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public FrmQuanLy()
        {
            InitializeComponent();
            CapNhatNut();
            CapNhatThongKe();
        }
        private bool DocDiem(out double diem)
        {
            bool ok = double.TryParse(txtDiem.Text, NumberStyles.Float,
           CultureInfo.InvariantCulture, out diem)
            && diem >= 0 && diem <= 10;
            if (!ok) MessageBox.Show("Diem phai la so trong [0; 10]", "Loi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return ok;
        }
        private void HienThi(string? maChon = null)
        {
            // Lấy danh sách phù hợp với từ khóa
            List<SinhVien> dsLoc = LayDanhSachLoc();

            // Hiển thị danh sách đã lọc
            lstSinhVien.Items.Clear();
            lstSinhVien.Items.AddRange(dsLoc.Cast<object>().ToArray());

            // Chọn lại sinh viên theo mã nếu sinh viên đó đang hiển thị
            if (maChon != null)
            {
                int vt = dsLoc.FindIndex(s => s.Ma == maChon);

                if (vt >= 0)
                    lstSinhVien.SelectedIndex = vt;
            }

            CapNhatNut();
            CapNhatThongKe();
        }
        private void CapNhatNut()
        {
            bool coChon = lstSinhVien.SelectedIndex >= 0;
            btnSua.Enabled = coChon;
            btnXoa.Enabled = coChon;
            txtMa.ReadOnly = coChon;
        }
        private void CapNhatThongKe()
        {
            List<SinhVien> dsLoc = LayDanhSachLoc();

            if (dsLoc.Count == 0)
            {
                lblThongKe.Text = "Ket qua: 0 sinh vien";
                return;
            }

            double diemTB = dsLoc.Average(s => s.Diem);

            lblThongKe.Text =
                $"Ket qua: {dsLoc.Count} sinh vien | " +
                $"Diem TB: {diemTB.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim(), ten = txtHoTen.Text.Trim();
            if (ma == "" || ten == "")
            { MessageBox.Show("Ma va ho ten khong duoc de trong"); return; }
            if (ds.Any(s => s.Ma == ma))
            { MessageBox.Show("Ma da ton tai"); return; }
            if (!DocDiem(out double diem)) return;
            ds.Add(new SinhVien { Ma = ma, HoTen = ten, Diem = diem });
            HienThi(ma);
            btnLamMoi_Click(sender, e);
        }
        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItem is SinhVien sv)
            {
                txtMa.Text = sv.Ma;
                txtHoTen.Text = sv.HoTen;
                txtDiem.Text = sv.Diem.ToString(CultureInfo.InvariantCulture);
            }
            CapNhatNut();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItem is not SinhVien sv) return;
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            { MessageBox.Show("Ho ten khong duoc de trong"); return; }
            if (!DocDiem(out double diem)) return;
            sv.HoTen = txtHoTen.Text.Trim();
            sv.Diem = diem;
            HienThi(sv.Ma);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItem is not SinhVien sv) return;
            var kq = MessageBox.Show($"Xoa sinh vien {sv.HoTen}?", "Xac nhan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;
            ds.Remove(sv);
            HienThi();
            btnLamMoi_Click(sender, e);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lstSinhVien.ClearSelected(); // kich hoat SelectedIndexChanged, nen xoa o nha sau cung

            txtMa.Clear(); txtHoTen.Clear(); txtDiem.Clear();
            CapNhatNut();
            txtMa.Focus();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Luu danh sach sinh vien";
                sfd.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "DanhSachSinhVien.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    string[] lines = ds.Select(s =>
                        $"{s.Ma};{s.HoTen};{s.Diem.ToString(CultureInfo.InvariantCulture)}"
                    ).ToArray();

                    File.WriteAllLines(sfd.FileName, lines, Encoding.UTF8);

                    MessageBox.Show(
                        $"Da luu {lines.Length} sinh vien.",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khi luu file: " + ex.Message);
                }
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Mo danh sach sinh vien";
                ofd.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    List<SinhVien> dsMoi = new();
                    List<int> dongLoi = new();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(';');

                        // Moi dong phai co dung 3 phan
                        if (parts.Length != 3)
                        {
                            dongLoi.Add(i + 1);
                            continue;
                        }

                        string ma = parts[0].Trim();
                        string ten = parts[1].Trim();

                        // Kiem tra ma va ho ten
                        if (ma == "" || ten == "")
                        {
                            dongLoi.Add(i + 1);
                            continue;
                        }

                        // Kiem tra diem
                        bool diemHopLe = double.TryParse(
                            parts[2].Trim(),
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double diem
                        ) && diem >= 0 && diem <= 10;

                        if (!diemHopLe)
                        {
                            dongLoi.Add(i + 1);
                            continue;
                        }

                        // Khong cho phep trung ma
                        if (dsMoi.Any(s => s.Ma == ma))
                        {
                            dongLoi.Add(i + 1);
                            continue;
                        }

                        dsMoi.Add(new SinhVien
                        {
                            Ma = ma,
                            HoTen = ten,
                            Diem = diem
                        });
                    }

                    // Thay danh sach hien tai bang danh sach doc duoc
                    ds.Clear();
                    ds.AddRange(dsMoi);

                    HienThi();
                    btnLamMoi_Click(sender, e);

                    string thongBao =
                        $"Da doc {ds.Count} sinh vien.\n" +
                        $"So dong loi: {dongLoi.Count}";

                    if (dongLoi.Count > 0)
                    {
                        thongBao += "\nCac dong loi: " +
                            string.Join(", ", dongLoi);
                    }

                    MessageBox.Show(
                        thongBao,
                        "Ket qua doc file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khi doc file: " + ex.Message);
                }
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
