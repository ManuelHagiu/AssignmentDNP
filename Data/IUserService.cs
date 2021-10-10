using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        User validateUser(string userName, string password);
    }
}