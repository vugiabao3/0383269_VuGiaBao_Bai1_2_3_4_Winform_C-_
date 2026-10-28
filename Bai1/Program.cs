using Bai1;

namespace Windows_Forms_HUCE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var login = new FrmDangNhap())
            {
                if (login.ShowDialog() != DialogResult.OK) return; // thoat neu khong dang nhap 
            Application.Run(new FrmChinh(login.TenDangNhap));
            }
        }
    }
}