using System.Data.SqlClient;
using System.Data;

namespace Form1.Bill.Model
{
    public class BillDetails
    {
        public string? Id_order { set; get; }
        public string? Id_food { set; get; }
        public int Amount { set; get; }

        public BillDetails() { }
        public BillDetails(string id_or, int amount) 
        {
            Id_order = id_or;
            Amount = amount;
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

        public void GetID_Food(string nameFood)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select MaMon from InfoFood where [TenMon] = @nameFood";
            cmd.Parameters.Add("nameFood", SqlDbType.NVarChar).Value = nameFood;
            
            DataTable dt = ExecuteCommand(cmd);
            if(dt != null)
            {
                Id_food = dt.Rows[0][0].ToString();
            }
        }

        public void AddDetailsBill()
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "insert into ChiTietHD values(@id_order, @id_food, @amount)";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = Id_order;
            cmd.Parameters.Add("id_food", SqlDbType.NVarChar).Value = Id_food;
            cmd.Parameters.Add("amount", SqlDbType.Int).Value = Amount;

            ExecuteCommand(cmd);
        }
    }
}
