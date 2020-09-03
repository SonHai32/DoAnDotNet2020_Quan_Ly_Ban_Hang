using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class DonHang
    {
        private String soHD;
        private String maKH;
        private String taiKhoan;
        private String diaChiGH;
        private String ghiChu;
        private DateTime ngayDat;
        private DateTime ngayGH;
        private bool daKichHoat;

        public DonHang(string soHD, string maKH, string taiKhoan, string diaChiGH, string ghiChu, DateTime ngayDat, DateTime ngayGH, bool daKichHoat)
        {
            this.soHD = soHD;
            this.maKH = maKH;
            this.taiKhoan = taiKhoan;
            this.diaChiGH = diaChiGH;
            this.ghiChu = ghiChu;
            this.ngayDat = ngayDat;
            this.ngayGH = ngayGH;
            this.daKichHoat = daKichHoat;
        }

        public string SoHD { get => soHD; set => soHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string DiaChiGH { get => diaChiGH; set => diaChiGH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public DateTime NgayGH { get => ngayGH; set => ngayGH = value; }
        public bool DaKichHoat { get => daKichHoat; set => daKichHoat = value; }
    }
}
