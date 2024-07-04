using System.Data.SqlClient;
using System.Data;

namespace Form1.Connect_DB.Model
{
    public class Account
    {
        public string? usn { get; set; }
        public string? pwd { get; set; }

        public Account (string un, string pw)
        {
            usn = un;
            pwd = pw;
        }

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

        public bool IsExisted()
        {
            try
            {
                var cmd = SqlCommandText;

                cmd.CommandText = "select count(*) from ThongTinDangNhap where [usn] = @usn and [pwd] = @pwd";
                cmd.Parameters.Add("usn", SqlDbType.VarChar).Value = usn;
                cmd.Parameters.Add("pwd", SqlDbType.VarChar).Value = pwd;

                DataTable dt = ExecuteCommand(cmd);
                if (dt != null && dt.Rows.Count == 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
                    {
                        return false;
                    }
                }
            }
            catch
            {

            }

            return true;
        }
    }
}
