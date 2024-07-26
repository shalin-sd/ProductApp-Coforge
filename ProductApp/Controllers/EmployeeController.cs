using Microsoft.AspNetCore.Mvc;
using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Service;

namespace ProductApp.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeOperation employeeOperation;
        public EmployeeController()
        {
            employeeOperation = new EmployeeService();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShowEmp()
        {
            var result = employeeOperation.GetAllEmployee();
            return View(result);

        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmp(Employee employee)
        {
            var result = employeeOperation.AddEmployee(employee);
            if (result > 0)
            {
                ViewBag.Message = "Employee Added Succesfully";
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateEmployee()
        {
            return View();
        }

            [HttpPost]
        public IActionResult UpdateEmployee(Employee employee) 
        {
            var result = employeeOperation.UpdateEmployee(employee.EmployeeId, employee.Name);
            if (result > 0)
            {
                ViewBag.Message = "Employee update Succesfully";
            }
            return View();
        }
        [HttpGet]
        public IActionResult DeleteEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DeleteEmployee(Employee employee)
        {
            var r = employeeOperation.DeleteEmployee(employee.EmployeeId);
            if (r > 0)
            {
                ViewBag.Message = "Employee Removed";
                return RedirectToAction("ShowEmp", "Employee"); // Redirect to action after successful removal
            }
            return View();

        }


    }
}
