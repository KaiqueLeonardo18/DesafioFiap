using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class TurmaException : Exception
    {
        public TurmaException()
        {
            
        }

        public TurmaException(string message) : base(message)
        {
            
        }

        public TurmaException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
