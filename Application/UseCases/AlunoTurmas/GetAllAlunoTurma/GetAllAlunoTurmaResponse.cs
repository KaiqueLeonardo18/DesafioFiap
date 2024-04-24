using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AlunoTurmas.GetAllAlunoTurma
{
    public class GetAllAlunoTurmaResponse
    {
        public string NomeAluno { get; set; }
        public string UsuarioAluno { get; set; }
        public string NomeTurma { get; set; }
        public int AnoTurma { get; set; }
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }
    }
}
