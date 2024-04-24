using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Turmas.GetAll
{
    public class GetAllTurmaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public bool Ativo { get; set; }
    }
}
