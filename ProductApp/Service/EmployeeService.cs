using ProductApp.Database;
using ProductApp.Functionality;
using ProductApp.Models;

namespace ProductApp.Service
{
    public class EmployeeService : IEmployeeOperation
    {
        AccountDbContext dbContext;
        public EmployeeService()
        {
            dbContext = new AccountDbContext();
        }
        int IEmployeeOperation.AddEmployee(Employee employee)
        {
            dbContext.employees.Add(employee);
            return dbContext.SaveChanges();

        }

        int IEmployeeOperation.CreateEmployee(int id, string name)
        {
            throw new NotImplementedException();
        }

        int IEmployeeOperation.DeleteEmployee(int id)
        {
            var del = dbContext.employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            dbContext.employees.Remove(del);
            //r DeletedResult = dbContext.employees.Find(id);
            //if(DeletedResult!=null)
            //dbContext.employees.Remove(DeletedResult);
            return dbContext.SaveChanges();
        }

        List<Employee> IEmployeeOperation.GetAllEmployee()
        {
            var result = dbContext.employees.ToList();
            return result;
        }

        int IEmployeeOperation.UpdateEmployee(int id, string name)
        {
            var s = dbContext.employees.Where(p => p.EmployeeId == id).FirstOrDefault();
            if (s == null)
            {
                return 0;
            }
            s.Name= name;
            return dbContext.SaveChanges();
            
        }
    }
}
