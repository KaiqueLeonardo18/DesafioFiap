using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.Create
{
    public sealed record CreateAlunoResponse
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string senha { get; set; }
    }
}
