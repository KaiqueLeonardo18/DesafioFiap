using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("[Aluno_Turma]")]
    public class AlunoTurma
    {
        [Key]
        public int AlunoId { get; set; }
        [Key]
        public int TurmaId { get; set; }
    }
}
