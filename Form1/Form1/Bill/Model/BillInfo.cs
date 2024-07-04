using System.Data.SqlClient;
using System.Data;

namespace Form1.Bill.Model
{
    public class BillInfo
    {
        public string? ID_order { get; set; }
        public string? NameCus { get; set; }
        public string? TimeOrder { get; set; }

        public BillInfo()
        {

        }

        const string CON = @"Data Source=DESKTOP-56H3GC4\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";
        public SqlCommand SqlCommandText
        {
            get
            {
                SqlCommand _SqlCommandText = new SqlCommand();
                SqlConnection SqlConnection = new SqlConnection(CON);
                _SqlCommandText.Connection = SqlConnection;
                _SqlCommandText.CommandType = System.Data.CommandType.Text;

                return _SqlCommandText;
            }
        }
        public DataTable ExecuteCommand(SqlCommand SqlCommandText)
        {
            SqlDataAdapter da = new SqlDataAdapter(SqlCommandText);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void ShowListBills(DataGridView dgv)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select * from HoaDon";
            DataTable dt = ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsExistedBill(string id_order)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select count(*) from HoaDon where [MaHD] = @id_order";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return true;     
                }
            }
            return false;
        }

        public void GetInfoBill(string? id_order)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select * from HoaDon where [MaHD] = @id_order";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = ExecuteCommand(cmd);
            if(dt != null)
            {
                ID_order = dt.Rows[0][0].ToString();
                NameCus = dt.Rows[0][1].ToString();
                TimeOrder = dt.Rows[0][3].ToString();
            }
        }

        public void ShowDetailsBill(string? id_order, DataGridView dgv)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select distinct TenMon, CT.SoLuong, I.DonGia, I.DonGia*CT.SoLuong as TongTien from ChiTietHD CT, HoaDon HD, InfoFood I where CT.MaHD = @id_order and CT.MaMon = I.MaMon";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }
    }
}
