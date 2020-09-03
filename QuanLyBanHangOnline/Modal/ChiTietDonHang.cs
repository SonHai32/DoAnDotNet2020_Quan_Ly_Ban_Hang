using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class ChiTietDonHang
    {

        private String soHD;
        private String maSP;
        private int soLuong;
        private Double giaBan;
        private float giamGia;

        public ChiTietDonHang(string soHD, string maSP, int soLuong, double giaBan, float giamGia)
        {
            this.soHD = soHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.giamGia = giamGia;
        }

        public string SoHD { get => soHD; set => soHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }
    }
}
