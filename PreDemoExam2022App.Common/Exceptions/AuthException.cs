using System;
using System.Diagnostics;

namespace PreDemoExam2022App.Common.Exceptions
{
    public class AuthException : Exception
    {
        public AuthException()
        {
        }

        public AuthException(string message) : base(message)
        {
        }

        public AuthException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
