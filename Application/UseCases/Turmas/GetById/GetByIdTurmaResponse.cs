using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetById
{
    public class GetByIdTurmaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
    }
}
