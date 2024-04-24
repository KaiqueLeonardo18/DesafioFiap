using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.Create
{
    public class CreateAlunoTurmaResponse
    {
        public string NomeAluno { get; set; }
        public string UsuarioAluno { get; set; }
        public string NomeTurma { get; set; }
        public int AnoTurma { get; set; }
        public int alunoId { get; set; }
        public int turmaId { get; set; }
    }
}
