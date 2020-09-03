using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class NhomTK
    {
        private int maNhom;
        private String tenNhom;
        private String ghiChu;

        public NhomTK(int maNhom, string tenNhom, string ghiChu)
        {
            this.maNhom = maNhom;
            this.tenNhom = tenNhom;
            this.ghiChu = ghiChu;
        }

        public int MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
