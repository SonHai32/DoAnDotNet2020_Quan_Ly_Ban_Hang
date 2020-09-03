using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class KhachHang
    {
        private String maKH;
        private String tenKH;
        private String soDT;
        private String email;
        private String diaChi;
        private String maQH;
        private String ghiChu;

        public KhachHang(string maKH, string tenKH, string soDT, string email, string diaChi, string maQH, string ghiChu)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.soDT = soDT;
            this.email = email;
            this.diaChi = diaChi;
            this.maQH = maQH;
            this.ghiChu = ghiChu;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaQH { get => maQH; set => maQH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
