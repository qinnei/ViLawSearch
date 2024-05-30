using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();          
        }

        private void btnKhaiNiem_Click(object sender, EventArgs e)
        {
            mainView.Controls.Clear();
            Form childform = new frmKhaiNiem();
            childform.TopLevel = false;
            mainView.Controls.Add(childform);
            childform.Show();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            mainView.Controls.Clear();
            Form childform = new frmQuyDinh();
            childform.TopLevel = false;
            mainView.Controls.Add(childform);
            childform.Show();
        }

        private void btnMucPhat_Click(object sender, EventArgs e)
        {
            mainView.Controls.Clear();
            Form childform = new frmMucPhat();
            childform.TopLevel = false;
            mainView.Controls.Add(childform);
            childform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            string s = "Môn học: Các phương pháp học thống kê\n" +
                "Giảng viên hướng dẫn: TS. Nguyễn Đình Hiển\n" +
                "Nhóm: Xác suất thống kê\n" +
                " Nguyễn Khánh Duy-47.01.104.077 \n Võ Thị Quế Trân-47.01.104.215 \n Trần Tú Quyên-47.01.104.180 \n Hồ Sĩ Thiện-47.01.104.199";
            MessageBox.Show(s);
        }
    }
}
