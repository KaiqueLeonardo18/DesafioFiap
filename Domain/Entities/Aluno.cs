
using Dapper.Contrib.Extensions;

namespace Domain.Entities
{
    [Table("[Aluno]")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string senha { get; set; }
    }
}
