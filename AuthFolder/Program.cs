using System;
using AuthGenerate;

namespace Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthClass Auth = new AuthClass();
            string userInput = "root";
            string userPassword ="secret";
            Auth.login(userInput,userPassword);
            Auth.validate(userInput,userPassword);
            Auth.user();
            Auth.id();
            Auth.check();
            Auth.guest();
            Auth.lastLogin();
            Auth.logout();
        }

    }
}
