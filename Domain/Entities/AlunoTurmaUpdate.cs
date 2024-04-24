using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AlunoTurmaUpdate
    {
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }
        public int AlunoIdOld { get; set; }
        public int TurmaIdOld { get; set; }
        public bool Ativo { get; set; }
    }
}
