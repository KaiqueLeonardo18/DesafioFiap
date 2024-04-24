using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Alunos.GetById
{
    public class GetByIdAlunoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string senha { get; set; }
        public bool Ativo { get; set; }
    }
}
