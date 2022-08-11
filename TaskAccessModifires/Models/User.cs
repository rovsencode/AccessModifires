using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAccessModifires.Models
{
    class User
    {
        string password;
        string userName;
        public string UserName {
            get
            {
                return (userName);
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    userName = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return (password);
            }

            set
            {
                if (value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    password = value;
                }

            }
        
        }
        public User(string username)
        {
            this.userName = username;
        }
        public static bool HasDigit(string password)
        { 
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i]) )
                    {
                        return true;
                    }
                }  

            return false;
        }
        public static bool HasUpper (string password)
        {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        return true;
                    }
                }
            return false;
        }
        public static bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            { 
                if (Char.IsLetter(password[i]) )
                { 
                    return true;
                }
            }
            return false;
        }
        public void ShowProfile()
        {
            Console.WriteLine("User"+" "+ userName+" password"+ " " +password);
        }
    }
    }