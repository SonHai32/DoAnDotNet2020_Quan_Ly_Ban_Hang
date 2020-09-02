using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyBanHangOnline.Controller
{
    class DAOSanPham
    {
        private String maSP;
        private String tenSP;
        private String hinhDD;
        private String ndTomTat;
        private String nhaSanXuat;
        private DateTime ngayDang;
        private String maLoai;
        private String noiDung;
        private String taiKhoan;
        private Double giaBan ;
        private float giamGia;
        private bool daDuyet;

        public DAOSanPham(string maSP, string tenSP, string hinhDD, string ndTomTat, string nhaSanXuat, DateTime ngayDang, string maLoai, string noiDung, string taiKhoan, double giaBan, float giamGia, bool daDuyet)
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

        public bool insertData(DAOSanPham sanPham)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO dbo.sanPham (maSP, tenSP, hinhDD, ndTomTat, nhaSanXuat, ngayDang, " +
                "maLoai, noiDung, taiKhoan, giaBan, giamGia, daDuyet ) values('@maSP', '@tenSP', '@hinhDD', '@ndTomTat', '@nhaSanXuat', '@ngayDang'" +
                ", " +
                "'@maLoai', '@noiDung', '@taiKhoan', @giaBan, @giamGia, @daDuyet)";
            command.Parameters.AddWithValue("@masp", sanPham.MaSP);
            command.Parameters.AddWithValue("@tenSP", sanPham.TenSP);
            command.Parameters.AddWithValue("@hinhDD", sanPham.HinhDD);
            command.Parameters.AddWithValue("@ndTomTat", sanPham.NdTomTat);
            command.Parameters.AddWithValue("@nhaSanXuat", sanPham.NhaSanXuat);
            command.Parameters.AddWithValue("@ngayDang", sanPham.NgayDang);
            command.Parameters.AddWithValue("@maLoai", sanPham.MaLoai);
            command.Parameters.AddWithValue("@noiDung", sanPham.NoiDung);
            command.Parameters.AddWithValue("@taiKhoan", sanPham.TaiKhoan);
            command.Parameters.AddWithValue("@giaBan", sanPham.GiaBan);
            command.Parameters.AddWithValue("@giamGia", sanPham.GiamGia);
            command.Parameters.AddWithValue("@daDuyet", sanPham.DaDuyet ? 1 : 0);

            try{
                SqlConnection con = new DAO().getConnection();
                con.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch(SqlException e)
            {
                return false;
            }
            

            //String queryString = "INSERT INTO dbo.sanPham (maSP, tenSP, hinhDD, ndTomTat, nhaSanXuat, ngayDang, " +
            //    "maLoai, noiDung, taiKhoan, giaBan, giamGia, daDuyet ) values('"+sanPham.maSP+"', '"+sanPham.tenSP+"', '"+sanPham.hinhDD+"', '"+sanPham.ndTomTat+"', " +
            //    "'"+sanPham.nhaSanXuat+"', '"+sanPham.ngayDang.ToString("yyyy/MM/dd")+"', '"+sanPham.maLoai+"', '"+sanPham.noiDung+"', '"+sanPham.noiDung+"', "+sanPham.giaBan+", "+sanPham.giamGia+", "+(sanPham.daDuyet ? 1 : 0)+")";
           // return new DAO().executeCommands(new DAO().getConnection(), queryString);
        }

        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
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
