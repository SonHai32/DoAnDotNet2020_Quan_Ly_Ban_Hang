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
        

        

        public bool insertData(SanPham sanPham)
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

        
    }
}
