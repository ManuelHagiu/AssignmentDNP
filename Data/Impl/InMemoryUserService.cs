using System;
using System.IO;
using System.Linq;
using FileData;
using Models;

namespace Assignment1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private FileContext file = new FileContext();

        public User validateUser(string username, string password)
        {
            User first = file.Users.FirstOrDefault(user => user.UserName.Equals(username));

            if (first == null)
            {
                throw new Exception("User not found");
            }
            
            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect Password");
            }

            return first;
        }
    }
}