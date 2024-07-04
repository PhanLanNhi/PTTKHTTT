using System.Data;
using System.Data.SqlClient;

namespace Form1.Employee.Model
{
    public class EmployeeModel
    {
        public string? ID_empl { get; set; }
        public string? Name_empl { get; set; }
        public string? Sex { get; set; }
        public string? DateBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        public EmployeeModel() { }
        public EmployeeModel(string? id)
        {
            ID_empl = id;
        }
        public EmployeeModel(string? id, string? name, string? sex, string? date, string? numphone, string? address)
        {
            ID_empl = id;
            Name_empl = name;
            Sex = sex;
            DateBirth = date;
            PhoneNumber = numphone;
            Address = address;
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

        public void ShowListEmployee(DataGridView dgv)
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select * from ThongTinNV";
            DataTable dt = ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsExistedEmployee()
        {
            var cmd = SqlCommandText;
            cmd.CommandText = "select count(*) from ThongTinNV where [MaNV] = @id_empl";
            cmd.Parameters.Add("id_empl", SqlDbType.VarChar).Value = ID_empl;
            DataTable dt = ExecuteCommand(cmd);
            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() != "1")
                {
                    return true;
                }
            }
            return false;
        }

        public string CreateEmployee()
        {
            bool isExisted = IsExistedEmployee();
            if (isExisted)
            {
                var cmd = SqlCommandText;
                cmd.CommandText = "insert into ThongTinNV values(@id, @name, @sex, @birth, @phone, @address)";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = Name_empl;
                cmd.Parameters.Add("sex", SqlDbType.NVarChar).Value = Sex;
                cmd.Parameters.Add("birth", SqlDbType.VarChar).Value = DateBirth;
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = PhoneNumber;
                cmd.Parameters.Add("address", SqlDbType.NVarChar).Value = Address;
                ExecuteCommand(cmd);
                return string.Empty;
            }
            return "Đã tồn tại nhân viên này trong hệ thống!";
        }

        public string UpdateEmployee()
        {
            try
            {
                var cmd = SqlCommandText;
                cmd.CommandText = "update ThongTinNV set [TenNV] = @name, [GioiTinh] = @sex, [NgaySinh] = @birth, [Sdt] = @phone, [Que] = @address where [MaNV] = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = Name_empl;
                cmd.Parameters.Add("sex", SqlDbType.NVarChar).Value = Sex;
                cmd.Parameters.Add("birth", SqlDbType.VarChar).Value = DateBirth;
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = PhoneNumber;
                cmd.Parameters.Add("address", SqlDbType.NVarChar).Value = Address;
                ExecuteCommand(cmd);
                return string.Empty;
            }
            catch { }
            return "Không thể cập nhật thông tin tại thời điểm này!";
        }

        public string DeleteEmployee()
        {
            try
            {
                var cmd = SqlCommandText;
                cmd.CommandText = "delete from ThongTinNV where [MaNV] = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                ExecuteCommand(cmd);
                return string.Empty;
            }
            catch { }
            return "Không thể xóa vào thời điểm này!";
        }
    }
}
