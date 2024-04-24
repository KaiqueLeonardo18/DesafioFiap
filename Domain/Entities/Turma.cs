using Dapper.Contrib.Extensions;

namespace Domain.Entities
{
    [Table("[Turma]")]
    public class Turma
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        [Write(false)]
        public List<Aluno> Alunos { get; set; }
    }
}
