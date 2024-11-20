using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet9Test
{
    public class MyCustomException : Exception
    {

        public MyCustomException(string message) : base(message) 
        {
            
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException) 
        {
            
        }

    }
}
