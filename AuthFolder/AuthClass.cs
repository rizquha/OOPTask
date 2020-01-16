using System;

namespace AuthGenerate
{
    class AuthClass
    {
        public string username = "root";
        public string password = "secret";
        public string loginUser="";
        public string loginPassword="";
        public string loginId="";
        public void login(string userInput, string passwordInput)
        {   
            Console.WriteLine("\n");
            if(username == userInput && password == passwordInput)
            {
                loginUser = userInput;
                loginPassword = passwordInput;
                loginId = "user1";
                Console.WriteLine("Anda berhasil login \n");
            }
            else if(username == userInput && password != passwordInput)
            {
                Console.WriteLine("Password yang anda masukkan salah");
            }
            else if(username != userInput && password == passwordInput)
            {
                Console.WriteLine("Username yang anda masukkan salah");
            }
            else
            {
                Console.WriteLine("Username dan password yang anda masukkan salah");
            }
        }
        public void validate(string userInput, string passwordInput)
        {
            if(username == userInput && password == passwordInput)
            {   
                Console.WriteLine("Akun anda tersedia\n");
            }
            else if(username == userInput && password != passwordInput)
            {
                Console.WriteLine("Password yang anda masukkan salah\n");
            }
            else if(username != userInput && password == passwordInput)
            {
                Console.WriteLine("Username Salah\n");
            }
            else
            {
                Console.WriteLine("Username yang anda masukkan salah\n");
            }
        }
        public void logout()
        {
            loginUser.Remove(0);
            loginPassword.Remove(0);
            Console.WriteLine("Anda berhasil logout\n");
        }
        public void user()
        {
            Console.WriteLine("user :" + loginUser);
            Console.WriteLine("password :" + loginPassword);   
            Console.WriteLine("\n");
        }
        public void id()
        {
            Console.WriteLine("id user :" + loginId);
            Console.WriteLine("\n");

        }
        public bool check()
        {
             if(loginUser == username)
            {
                Console.WriteLine("true\n");
                return true;
            }
            else 
            {
                Console.WriteLine("false\n");
                return false;
            }
        }
        public bool guest()
        {
            if(loginUser =="")
            {
                Console.WriteLine("true\n");
                return true;
            }
            else 
            {
                Console.WriteLine("false\n");
                return false;
            }
        }
        public void lastLogin()
        {
             Console.WriteLine("Last Login User : " + loginUser); 
             Console.WriteLine("\n");
        }

    }
}