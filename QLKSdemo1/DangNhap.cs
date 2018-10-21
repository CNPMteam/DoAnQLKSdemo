using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace QLKSdemo1
{
    public partial class DangNhap : MetroForm
    {
        public DangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        private void NutLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (xacnhan("loginchinh".Trim(), TaiKhoanBox.Text.Trim(), MatKhauBox.Text.Trim()))
                {
                    this.Hide();
                    MenuChinh quanly_ks = new MenuChinh();
                    quanly_ks.Show();
                }
                else if (xacnhan("logindichvu".Trim(), MatKhauBox.Text.Trim(), MatKhauBox.Text.Trim()))
                {
                    this.Hide();
                    MenuDichVu quanly_dv = new MenuDichVu();
                    quanly_dv.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Tai khoan va mat khau cua ban co van de", "Dang Nhap That Bai", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Loi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        public bool xacnhan(string tentable, string id, string password)
        {
            bool success = false;
            SqlConnection connection = new SqlConnection(QLKSdemo1.Properties.Settings.Default.dangnhapdataConnectionString);
            string sql = "SELECT* FROM " + tentable + " WHERE taikhoan=@id AND matkhau=@password";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = id;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Loi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }

        private void TaiKhoanBox_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBox.Text == string.Empty)
            {
                IDnhan.Visible = true;
            }
            if (IDnhan.Text != "TaiKhoan" && IDnhan.Text != string.Empty)
            {
                IDnhan.Visible = false;
            }
        }

        private void MatKhauBox_Click(object sender, EventArgs e)
        {
            if (MatKhauBox.Text == string.Empty)
            {
                PasswordNhan.Visible = true;
            }
            if (MatKhauBox.Text != "MatKhau" && MatKhauBox.Text != string.Empty)
            {
                PasswordNhan.Visible = false;
            }
        }


        private void Help_Click(object sender, EventArgs e)
        {
            MucHelp mo_help = new MucHelp();
            mo_help.Show();
        }
    }
}
