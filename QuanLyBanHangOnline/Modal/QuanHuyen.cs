using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangOnline.Modal
{
    class QuanHuyen
    {
        private int maQH;
        private String tenQH;
        private String tinhThanh;
        private String ghiChu;

        public QuanHuyen(int maQH, string tenQH, string tinhThanh, string ghiChu)
        {
            this.maQH = maQH;
            this.tenQH = tenQH;
            this.tinhThanh = tinhThanh;
            this.ghiChu = ghiChu;
        }

        public int MaQH { get => maQH; set => maQH = value; }
        public string TenQH { get => tenQH; set => tenQH = value; }
        public string TinhThanh { get => tinhThanh; set => tinhThanh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
