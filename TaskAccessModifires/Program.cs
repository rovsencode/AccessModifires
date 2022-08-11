using System;
using TaskAccessModifires.Models;

namespace TaskAccessModifires
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User Usertype = new User("rovsen_code");
           
            Usertype.Password = "Code2017a";
            Usertype.ShowProfile();

        }
    }
}
