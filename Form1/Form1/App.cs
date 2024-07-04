using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button_LichLam_Click(object sender, EventArgs e)
        {
            new FormQLLL().Show();
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            new FormQLNV().Show();
            Close();
        }

        private void button_MonAn_Click(object sender, EventArgs e)
        {
            new FormQLMonAn().Show();
            Close();
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            new Form_LapHoaDon().Show();
            Close();
        }

        private void button_DoanhThu_Click(object sender, EventArgs e)
        {
            new QuanLyHD().Show();
        }

        private void bt_kho_Click(object sender, EventArgs e)
        {

        }
    }
}
