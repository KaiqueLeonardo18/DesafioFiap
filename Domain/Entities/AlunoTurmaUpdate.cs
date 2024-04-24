using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AlunoTurmaUpdate
    {
        public int alunoId { get; set; }
        public int turmaId { get; set; }
        public int alunoIdOld { get; set; }
        public int turmaIdOld { get; set; }
    }
}
