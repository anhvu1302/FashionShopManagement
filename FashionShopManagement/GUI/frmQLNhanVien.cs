﻿
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
    public partial class frmQLNhanVien : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;

        public frmQLNhanVien()
        {
            InitializeComponent();
            
        }

        private void loadtboNhanVien()
        {
            sql = "SELECT * FROM NhanVien";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "ID Nhân viên";
            dgv.Columns[1].HeaderText = "ID Người dùng";
            dgv.Columns[2].HeaderText = "Tên nhân viên";
            dgv.Columns[3].HeaderText = "Ngày sinh";
            dgv.Columns[4].HeaderText = "Giới tính";
            dgv.Columns[5].HeaderText = "Địa chỉ";
            dgv.Columns[6].HeaderText = "Số ĐT";
            dgv.Columns[7].HeaderText = "Email";
        }
       
        private void ResetNhanVien()
        {
            // Reset all TextBox controls related to employee information
            txt_IDNhanVien.Text = string.Empty;
            txt_IDNguoiDung.Text = string.Empty;
            txt_TenNhanVien.Text = string.Empty;
            txt_NgaySinh.Text = string.Empty;
            txt_GioiTinh.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_SoDienThoai.Text = string.Empty;
            txt_Email.Text = string.Empty;

            // Optionally, you can clear the selected rows in the DataGridView
            //dgv.ClearSelection();
        }

        private void btn_ResetNV_Click(object sender, EventArgs e)
        {
            // Call the ResetNhanVien function to reset all controls related to employee information
            ResetNhanVien();
        }

        private void btn_CapNhatNV_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin khách hàng?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE NhanVien SET TenNhanVien = N'{0}',NgaySinh='{1}' ,GioiTinh = N'{2}',DiaChi=N'{3}',SoDienThoai = {4},Email='{5}' WHERE IdNhanVien = {6}", txt_TenNhanVien.Text, txt_NgaySinh.Text, txt_GioiTinh.Text, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_Email.Text, txt_IDNhanVien.Text);
                config.ExecuteNonQuery(sql);
                loadtboNhanVien();
            }
        }


        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin Nhân viên?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE NhanVien WHERE IdNhanVien = {0}", txt_IDNhanVien.Text);
                config.ExecuteNonQuery(sql);
                loadtboNhanVien();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txt_IDNhanVien.Enabled = false;
                if (string.IsNullOrEmpty(txt_IDNguoiDung.Text) || string.IsNullOrEmpty(txt_TenNhanVien.Text) || string.IsNullOrEmpty(txt_NgaySinh.Text) || string.IsNullOrEmpty(txt_GioiTinh.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SoDienThoai.Text) || string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IDNguoiDung.Focus();
                    return;
                }
                string s = "select COUNT(*) from NhanVien where IdNguoiDung='" + txt_IDNguoiDung.Text + "'";
                Object check = config.ExecuteScalar(s);
                int kq = int.Parse(check.ToString());
                if (kq <= 0)
                {
                    sql = string.Format("INSERT INTO NhanVien VALUES('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}')",
                                txt_IDNguoiDung.Text,
                                txt_TenNhanVien.Text,
                                txt_NgaySinh.Text,
                                txt_GioiTinh.Text,
                                txt_DiaChi.Text,
                                txt_SoDienThoai.Text,
                                txt_Email.Text);
                    config.ExecuteNonQuery(sql);
                    loadtboNhanVien();
            }
                else
                {
                    MessageBox.Show("Đã tồn tại Mã Người Dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IDNguoiDung.Focus();
                    return;
                }
               
                btn_XoaNV.Enabled = true;
                btn_ThemNV.Enabled = true;
                btn_CapNhatNV.Enabled = true;

                btnLuu.Enabled = false;
                txt_IDNhanVien.Enabled = false;
            
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
           
                dgv.AllowUserToAddRows = true;
            btn_CapNhatNV.Enabled = false;
            btn_XoaNV.Enabled = false;
            btn_ResetNV.Enabled = true;
            btnLuu.Enabled = true;
            btn_ThemNV.Enabled = false;
            txt_IDNhanVien.Text = string.Empty;
            txt_IDNhanVien.Enabled = false;
            txt_IDNguoiDung.Focus();

                sql = "select * from NGUOIDUNG where IdNguoiDung='" + txt_IDNguoiDung.Text + "'";
                DataTable dt_NguoiDung = config.ExecuteSelectQuery(sql);
                if (dt_NguoiDung.Rows.Count == 0)
                {
                    MessageBox.Show("Không có Dữ liệu tài khoản ");
                    return;
                }
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    int index = e.RowIndex;
                txt_IDNhanVien.Text = dgv.Rows[index].Cells[0].Value.ToString();
                txt_IDNguoiDung.Text = dgv.Rows[index].Cells[1].Value.ToString();
                txt_TenNhanVien.Text = dgv.Rows[index].Cells[2].Value.ToString();
                    txt_NgaySinh.Text = dgv.Rows[index].Cells[3].Value.ToString();
                    txt_GioiTinh.Text = dgv.Rows[index].Cells[4].Value.ToString();
                    txt_DiaChi.Text = dgv.Rows[index].Cells[5].Value.ToString();
                    txt_SoDienThoai.Text = dgv.Rows[index].Cells[6].Value.ToString();
                    txt_Email.Text = dgv.Rows[index].Cells[7].Value.ToString();
                }
            
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            loadtboNhanVien();
        }
    }
}
