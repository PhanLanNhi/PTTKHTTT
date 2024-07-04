using Form1.Employee.Model;

namespace Form1.Employee.Services
{
    public class EmployeeService
    {
        public EmployeeService() { }
        public void ShowListEmployee(DataGridView dgv)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.ShowListEmployee(dgv);
        }

        public string CreateEmployee(string? id, string? name, string? sex, string? date, string? numphone, string? address)
        {
            EmployeeModel employee = new EmployeeModel(id, name, sex, date, numphone, address);
            return employee.CreateEmployee();
        }

        public string UpdateEmployee(string? id, string? name, string? sex, string? date, string? numphone, string? address)
        {
            EmployeeModel employee = new EmployeeModel(id, name, sex, date, numphone, address);
            return employee.UpdateEmployee();
        }

        public string DeleteEmployee(string? id)
        {
            EmployeeModel employee = new EmployeeModel(id);
            return employee.DeleteEmployee();
        }
    }
}
