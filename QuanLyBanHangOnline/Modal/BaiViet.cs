using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class BaiViet
    {
        private String maBV;
        private String tenBV;
        private String hinhDD;
        private String ndTomTat;
        private String maLoai;
        private String noiDung;
        private String taiKhoan;
        private DateTime ngayDang;
        private bool daDuyet;

        public BaiViet(string maBV, string tenBV, string hinhDD, string ndTomTat, string maLoai, string noiDung, string taiKhoan, DateTime ngayDang, bool daDuyet)
        {
            this.maBV = maBV;
            this.tenBV = tenBV;
            this.hinhDD = hinhDD;
            this.ndTomTat = ndTomTat;
            this.maLoai = maLoai;
            this.noiDung = noiDung;
            this.taiKhoan = taiKhoan;
            this.ngayDang = ngayDang;
            this.daDuyet = daDuyet;
        }

        public string MaBV { get => maBV; set => maBV = value; }
        public string TenBV { get => tenBV; set => tenBV = value; }
        public string HinhDD { get => hinhDD; set => hinhDD = value; }
        public string NdTomTat { get => ndTomTat; set => ndTomTat = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
        public bool DaDuyet { get => daDuyet; set => daDuyet = value; }
    }
}
