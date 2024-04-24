using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class TurmaExcepetion : Exception
    {
        public TurmaExcepetion()
        {
            
        }

        public TurmaExcepetion(string message) : base(message)
        {
            
        }

        public TurmaExcepetion(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
