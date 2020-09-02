using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyBanHangOnline
{
    public partial class Form1 
    {
        private Panel buttonControlLeftBorder;
        private IconButton currentButton;
        public Form1()
        {
            InitializeComponent();
            buttonControlLeftBorder = new Panel();
            buttonControlLeftBorder.Size = new Size(7, 80);

            string connectionString = @"Server=LAPTOP-HENIB6EN\SQLEXPRESS;Database=BanHang18;User=hhsh;Password=123";
            string sqlCommand = "SELECT tenSP, giaBan, ngayDang, giamGia, taiKhoan FROM dbo.sanPham";
            grvSanPham.DataSource = getDataSource(connectionString, sqlCommand); 
        }
 

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 141);
            public static Color color2 = Color.FromArgb(248, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private DataTable getDataSource(String connectionString, String query)
        {

            DataTable dataSource = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dataSource);
                
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataSource;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                this.currentButton = (IconButton)senderBtn;
                this.currentButton.BackColor = Color.FromArgb(22, 33, 62);
                this.currentButton.ForeColor = color;
                this.currentButton.TextAlign = ContentAlignment.MiddleCenter;
                this.currentButton.IconColor = color;
                this.currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                this.currentButton.ImageAlign = ContentAlignment.MiddleRight;

                buttonControlLeftBorder.BackColor = color;
                buttonControlLeftBorder.Location = new Point(0, this.currentButton.Location.Y);
                buttonControlLeftBorder.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(this.currentButton != null)
            {
                this.currentButton.BackColor = Color.FromArgb(22, 33, 62);
                this.currentButton.ForeColor = Color.FromArgb(233, 69, 96);
                this.currentButton.TextAlign = ContentAlignment.MiddleLeft;
                this.currentButton.IconColor = Color.FromArgb(233, 69, 96);
                this.currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                this.currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
            
        }


               private void btnThem_Click(object sender, EventArgs e)
        {
            new  FormSanPham().ShowDialog();
        }
    }
}
