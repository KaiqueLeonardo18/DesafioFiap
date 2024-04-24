using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class AlunoTurmaException : Exception
    {
        public AlunoTurmaException()
        {
            
        }

        public AlunoTurmaException(string message) : base(message)
        {
            
        }

        public AlunoTurmaException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
