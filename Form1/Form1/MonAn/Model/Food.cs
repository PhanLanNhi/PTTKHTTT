using System.Data;
using System.Data.SqlClient;

namespace Form1.MonAn.Model
{
    public class Food
    {
        public string? idFood { get; set; }
        public string? nameFood { get; set; }
        public string? priceFood { get; set; }
        public string? dateUpdate { get; set; }

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

        public void ShowListFood(DataGridView dgv)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select * from InfoFood";
            DataTable dt = ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsFoodExisted()
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select count(*) from InfoFood where [MaMon] = @idFood";
            cmd.Parameters.Add("idFood", SqlDbType.VarChar).Value = idFood;
            DataTable dt = ExecuteCommand(cmd);
            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() != "0")
                {
                    return true;
                }
            }
            return false;
        }

        public string AddFood()
        {
            var IsExisted = IsFoodExisted();
            if (IsExisted)
            {
                return "Món ăn đã có trong danh sách!";
            }

            var cmd = SqlCommandText;

            cmd.CommandText = "insert into InfoFood values(@idfood, @namefood, @pricefood, @datefood)";
            cmd.Parameters.Add("idfood", SqlDbType.VarChar).Value = idFood;
            cmd.Parameters.Add("namefood", SqlDbType.NVarChar).Value = nameFood;
            cmd.Parameters.Add("pricefood", SqlDbType.Int).Value = priceFood;
            cmd.Parameters.Add("datefood", SqlDbType.NVarChar).Value = dateUpdate;

            ExecuteCommand(cmd);

            return string.Empty;
        }

        public string UpdateFood()
        {
            var cmd = SqlCommandText;

            cmd.CommandText = "update InfoFood set [TenMon] = @namefood, [DonGia] = @pricefood, [ThoiGian] = @datefood where [MaMon] = @id_update";
            cmd.Parameters.Add("namefood", SqlDbType.NVarChar).Value = nameFood;
            cmd.Parameters.Add("pricefood", SqlDbType.Int).Value = priceFood;
            cmd.Parameters.Add("datefood", SqlDbType.NVarChar).Value = dateUpdate;
            cmd.Parameters.Add("id_update", SqlDbType.VarChar).Value = idFood;

            ExecuteCommand(cmd);

            return string.Empty;
        }

        public string DeleteFood()
        {
            var cmd = SqlCommandText;

            cmd.CommandText = "delete from InfoFood where [MaMon] = @id_delete";
            cmd.Parameters.Add("id_delete", SqlDbType.VarChar).Value = idFood;

            ExecuteCommand(cmd);

            return string.Empty;
        }
    }
}
