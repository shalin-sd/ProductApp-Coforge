using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Database;
namespace ProductApp.Service;

    public class AccountService : IAccountOperation
{
    AccountDbContext accountDbContext;
    public AccountService()
    {
        accountDbContext = new AccountDbContext();
    }
    int IAccountOperation.AccountCreate(Account account)
    {
        var result = accountDbContext.accounts.Add(account);
        return accountDbContext.SaveChanges();
    }

    int IAccountOperation.AccountValidate(string username, string pwd)
    {
        var result = accountDbContext.accounts.Where(u => u.UserName == username && u.Password == pwd).FirstOrDefault();
        if (result == null)
        {
            return 0;
        }
        return 1;
    }
}
