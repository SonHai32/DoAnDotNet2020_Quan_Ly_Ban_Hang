using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using QuanLyBanHangOnline.Modal;
namespace QuanLyBanHangOnline.Controller
{
    class DAOSanPham
    {

        public String insertData(SanPham sanPham)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO dbo.sanPham (maSP, tenSP, hinhDD, ndTomTat, nhaSanXuat, ngayDang, " +
                "maLoai, noiDung, taiKhoan, giaBan, giamGia, daDuyet ) values('@maSP', '@tenSP', '@hinhDD', '@ndTomTat', '@nhaSanXuat', '@ngayDang'" +
                ", " +
                "@maLoai, '@noiDung', '@taiKhoan', @giaBan, @giamGia, @daDuyet)";
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
                return command.ExecuteNonQuery() > 0 ? "Thêm Thành Công Sản Phẩm " + sanPham.MaSP: "Thêm Đơn Hàng Không Thành Công";
            }
            catch(SqlException e)
            {
                return e.Message;
            }
           
        }

        public String updateData(SanPham sanPham)
        {
//            String checkExistedMaLoaiQuery = "SELECT * FROM dbo.sanPham where maLoai="+sanPham.MaLoai+"";


            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE dbo.sanPham set maSP='@maSP', tenSP='@tenSP', hinhDD='@hinhDD', ndTomTat='@ndTomTat', nhaSanXuat='@nhaSanXuat', ngayDang='@ngayDang'" +
                ", " +
                "maLoai=@maLoai, noiDung='@noiDung', taiKhoan='@taiKhoan', giaBan=@giaBan, giamGia=@giamGia, daDuyet=@daDuyet)";
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
                return command.ExecuteNonQuery() > 0 ? "Sửa Đổi Thành Công Sản Phẩm" + sanPham.MaSP : "Sửa Đổi Không Thành Công" ;

            }
            catch(SqlException e)
            {
                return e.Message;
            }

        }

        
    }
}
