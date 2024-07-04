using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{
    public partial class FormQLLL : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-56H3GC4;Initial Catalog=QLNhaHang;Integrated Security=True";
        public FormQLLL()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaNV, TenNV from ThongTinNV";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataRow itemRow = table.NewRow();
            itemRow[1] = "Chọn nhân viên";
            table.Rows.InsertAt(itemRow, 0);

            cb_TenNV.DataSource = table;
            cb_TenNV.DisplayMember = "TenNV";
            cb_TenNV.ValueMember = "MaNV";

        }
        private void FormQLLL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }
    }
}
