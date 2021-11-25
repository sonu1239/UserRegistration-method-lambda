using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexValidate
    {
        //We are using this method to match pattern of first name and
        public static string FirstName(string name)
        {
            string firstRegName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3    
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1                                                           
            try
            {
                bool TestFirstName(string firstName) => (Regex.IsMatch(firstName, firstRegName));           //declaration of a method inside another method lamda
                bool output = TestFirstName(name);
                if (output)                                //it true, then proceed
                {
                    return "valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "invalid");         //throwing custom exceptions for handling invalid                   
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }
        }



        //We are using this method to match pattern of last name
        public static string LastName(string name)
        {
            string lastRegName = "^[A-Z]{1}[a-zA-Z]{2,}$";          //this regular exp shows that first letter must be capital, and minimum letter must be 3
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 
            try
            {
                bool TestLastName(string lastName) => (Regex.IsMatch(lastName, lastRegName));           //declaration of a method inside another method
                bool output = TestLastName(name);
                if (output)                                //it true, then proceed
                {
                    return "valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }
        }
        //This method for validation of email id
        public static string EmailValid(string mail)
        {
            string emailReg = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zx`xA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            //Regex regex = new Regex(emailid);
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 
            try
            {
                bool TestEmail(string email) => (Regex.IsMatch(email, emailReg));           //declaration of a method inside another method
                bool output = TestEmail(mail);
                if (output)                                //it true, then proceed
                {
                    return "valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }


        }
        //This method will check whether phone no is valid or not
        public static string MobileNumValid(string number)
        {
            string mobileReg = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$";         //here both country codes with 2 or 3 numbers will be valid. other than that invalid.
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 
            try
            {
                bool TestMobile(string mobile) => (Regex.IsMatch(mobile, mobileReg));           //declaration of a method inside another method
                bool output = TestMobile(number);
                if (output)                                          //it true, then proceed
                {
                    return "valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }

        }


        public static string PassWord(string pass)
        {
            string pwdReg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 
            try
            {
                bool TestPassword(string pwd) => (Regex.IsMatch(pwd, pwdReg));           //declaration of a method inside another method
                bool output = TestPassword(pass);
                if (output)                                //it true, then proceed
                {
                    return "valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "invalid");         //throwing custom exceptions for handling invalid
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Entry cannot be null");     //throwing custom exceptions for handling null entry
            }
        }

        //created array to check valid email ID.
        public static void EmailArr(string[] name)
        {
            string email = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            //+ means one or more.
            //*- zero or more.
            //?- zero or 1 

            Regex regex = new Regex(email);            //creating a regex named obj with regular exp email.
            foreach (var word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid.");
                }
                else
                    Console.WriteLine(word + " is invalid.");
            }

        }

    }
}
