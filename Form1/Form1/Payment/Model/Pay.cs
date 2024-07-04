using System.Data.SqlClient;
using System.Data;

namespace Form1.Payment.Model
{
    public class Pay
    {
        public string? NameProduct { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }

        const string CON = @"Data Source=DESKTOP-56H3GC4\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";

        public SqlCommand SqlCommandText
        {
            get
            {
                SqlCommand _SqlCommandText = new SqlCommand();
                SqlConnection sqlConnection = new SqlConnection(CON);
                _SqlCommandText.Connection = sqlConnection;
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

        public void AddItemToListView(ListView listview_payment)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select * from InfoFood where [TenMon] = @nameProduct";
            cmd.Parameters.Add("nameProduct", SqlDbType.NVarChar).Value = NameProduct;

            DataTable dt = ExecuteCommand(cmd);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                item.SubItems.Add("1");
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[2].ToString());
                listview_payment.Items.Add(item);
            }
        }

    }
}
