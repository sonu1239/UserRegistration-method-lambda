using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();

            Console.Write("Enter First Name : ");   //taking user input of first name
            string firstname = Console.ReadLine();
            RegexValidate.FirstName(firstname);
            Console.ReadLine();

            Console.Write("Enter Last Name : ");   //taking user input of Last name
            string lastname = Console.ReadLine();
            RegexValidate.LastName(lastname);
            Console.ReadLine();

            Console.Write("Enter Email ID: ");   //taking user input of Email ID
            string Email = Console.ReadLine();
            RegexValidate.EmailValid(Email);
            Console.ReadLine();

            Console.WriteLine("Enter mobile number in this format : 00 0000000000"); //taking user input of Mobile No
            string MobileNo = Console.ReadLine();
            RegexValidate.MobileNumValid(MobileNo);
            Console.ReadLine();

            Console.Write("Enter password: ");   //taking user input of password1
            string password1 = Console.ReadLine();
            RegexValidate.PassWord(password1);
            Console.ReadLine();

            Console.WriteLine("\n To checking valid and invalid emails!");
            string[] emailEntries = { "abc@gmail.com", "1.abc@yahoo.com", "2.abc-100@yahoo.com", "3.abc.100@yahoo.com", "2.abc111@abc.com", "4.abc-100@abc.net", "5.abc.100@abc.com.au", "6.abc@1.com", "7.abc@gmail.com.com", "8.abc+100@gmail.com" };
            string[] testInvalidEmail = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            RegexValidate.EmailArr(emailEntries);
            Console.WriteLine();
            RegexValidate.EmailArr(testInvalidEmail);

        }
    }
    
}
