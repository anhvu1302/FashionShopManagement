using FashionShopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FashionShopApp.GUI
{
    public partial class frmQLTaiKhoanNV : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        
        public frmQLTaiKhoanNV()
        {
            InitializeComponent();
        }
        void loadTKNhanVien()
        {
            sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro!=4";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Người dùng";
            dgv.Columns[1].HeaderText = "Tên Tài Khoản";
            dgv.Columns[2].HeaderText = "Mật Khẩu";
            dgv.Columns[3].HeaderText = "Tồn tại";
            dgv.Columns[4].HeaderText = "Khoá";
            dgv.AllowUserToAddRows = false;
        }
        private void frmTK_NhanVien_Load(object sender, EventArgs e)
        {
            loadTKNhanVien();
            txt_IdAcc.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Reset.Enabled = false;
            txt_tenTK.Focus();
        }
        void loadTKNhanVienSearch(string sql)
        {
            //sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro=4";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Người dùng";
            dgv.Columns[1].HeaderText = "Tên Tài Khoản";
            dgv.Columns[2].HeaderText = "Mật Khẩu";
            dgv.Columns[3].HeaderText = "Tồn tại";
            dgv.Columns[4].HeaderText = "Khoá";
            //dgv.AllowUserToAddRows = false;
        }
    }
}
