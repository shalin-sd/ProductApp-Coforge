using Microsoft.AspNetCore.Mvc;
using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Service;

namespace ProductApp.Controllers
{
    public class AccountController : Controller
    {
        IAccountOperation accountOperation;

        public AccountController()
        {
            accountOperation = new AccountService();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(Account account)
        {
            {
                var temp = accountOperation.AccountCreate(account);
                if (temp > 0)
                {
                    HttpContext.Session.SetString("User", account.UserName);
                    return RedirectToAction("Index", "DashBoard");
                }
                return View();
            }


        }


        [HttpGet]
        public IActionResult LoginValidate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginValidate(Account account)
        {
            {
                int temp = accountOperation.AccountValidate(account.UserName, account.Password);
                if (temp > 0)
                {
                    ViewBag.Message = "Account Created";
                }
                return View();
            }

        }
    }
}

