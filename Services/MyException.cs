using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class MyException : Exception
    {
        
        public MyException(string message) : base(message)
        {

        }
    }
}
