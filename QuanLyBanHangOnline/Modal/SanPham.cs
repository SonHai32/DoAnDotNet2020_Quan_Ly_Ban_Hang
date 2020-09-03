using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class SanPham
    {
        private String maSP;
        private String tenSP;
        private String hinhDD;
        private String ndTomTat;
        private String nhaSanXuat;
        private DateTime ngayDang;
        private int maLoai;
        private String noiDung;
        private String taiKhoan;
        private Double giaBan ;
        private float giamGia;
        private bool daDuyet;

        public SanPham(string maSP, string tenSP, string hinhDD, string ndTomTat, string nhaSanXuat, DateTime ngayDang, int maLoai, string noiDung, string taiKhoan, double giaBan, float giamGia, bool daDuyet)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.HinhDD = hinhDD;
            this.NdTomTat = ndTomTat;
            this.NhaSanXuat = nhaSanXuat;
            this.NgayDang = ngayDang;
            this.MaLoai = maLoai;
            this.NoiDung = noiDung;
            this.TaiKhoan = taiKhoan;
            this.GiaBan = giaBan;
            this.GiamGia = giamGia;
            this.DaDuyet = daDuyet;
        }

        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }
        public bool DaDuyet { get => daDuyet; set => daDuyet = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string HinhDD { get => hinhDD; set => hinhDD = value; }
        public string NdTomTat { get => ndTomTat; set => ndTomTat = value; }

    }
}
