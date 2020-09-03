using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class LoaiSanPham
    {
        private int maLoai;
        private String loaiSP;
        private String ghiChu;

        public LoaiSanPham(int maLoai, string loaiSP, string ghiChu)
        {
            this.maLoai = maLoai;
            this.loaiSP = loaiSP;
            this.ghiChu = ghiChu;
        }

        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
