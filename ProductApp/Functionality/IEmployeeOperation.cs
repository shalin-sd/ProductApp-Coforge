using ProductApp.Models;

namespace ProductApp.Functionality
{
    public interface IEmployeeOperation
    {
        int AddEmployee(Employee employee);
        int CreateEmployee(int id, string name);
        int DeleteEmployee(int id);
        List<Employee> GetAllEmployee();
        int UpdateEmployee(int id,string Name);
       
      
    }
}
