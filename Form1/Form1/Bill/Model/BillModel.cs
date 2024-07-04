using System.Data.SqlClient;
using System.Data;

namespace Form1.Bill.Model
{
    public class BillModel
    {
        public string? ID_order { get; set; }
        public string? NameCustomer { get; set; }
        public double Total { get; set; }
        public string? TimeBill { get; set; }

        public BillModel() 
        {
            
        }

        public BillModel(string id, string namecus, double total, string timeorder) 
        {
            ID_order = id;
            NameCustomer = namecus;
            Total = total;
            TimeBill = timeorder;
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

        public void AddBill()
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "insert into HoaDon values(@id, @namecus, @total, @timeorder)";
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_order;
            cmd.Parameters.Add("namecus", SqlDbType.NVarChar).Value = NameCustomer;
            cmd.Parameters.Add("total", SqlDbType.Float).Value = Total;
            cmd.Parameters.Add("timeorder", SqlDbType.VarChar).Value = TimeBill;

            ExecuteCommand(cmd);
        }

        public void AutoNumberBill()
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select max(MaHD+1) from HoaDon";
            DataTable dt = ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                ID_order = dt.Rows[0][0].ToString();
            }
            else
            {
                ID_order = "1";
            }
        }
    }
}
