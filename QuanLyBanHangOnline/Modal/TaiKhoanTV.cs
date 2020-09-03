using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class TaiKhoanTV
    {
        private String taiKhoan;
        private String matKhau;
        private String hoDem;
        private String tenTV;
        private String soDT;
        private String email;
        private String diaChi;
        private String ghiChu;
        private int maNhom;
        private int maQH;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private bool trangThai;

        public TaiKhoanTV(string taiKhoan, string matKhau, string hoDem, string tenTV, string soDT, string email, string diaChi, string ghiChu, int maNhom, int maQH, DateTime ngaySinh, bool gioiTinh, bool trangThai)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoDem = hoDem;
            this.tenTV = tenTV;
            this.soDT = soDT;
            this.email = email;
            this.diaChi = diaChi;
            this.ghiChu = ghiChu;
            this.maNhom = maNhom;
            this.maQH = maQH;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.trangThai = trangThai;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoDem { get => hoDem; set => hoDem = value; }
        public string TenTV { get => tenTV; set => tenTV = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaNhom { get => maNhom; set => maNhom = value; }
        public int MaQH { get => maQH; set => maQH = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
