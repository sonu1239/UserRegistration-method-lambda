using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        /// <summary>
        /// enum for exception type
        /// enums are like constant values which are numeric integer numbers which either the user assigns or default starting from  0,1,2...
        /// </summary>
        ///er
        public ExceptionType type;
        public enum ExceptionType
        {
            NULL_VALUE, INVALID_ENTRY

        }

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
