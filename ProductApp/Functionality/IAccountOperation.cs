using ProductApp.Models;

namespace ProductApp.Functionality
{
    public  interface IAccountOperation
    {
        int AccountCreate(Account account);
        int AccountValidate(string username, string pwd);

    }
}
