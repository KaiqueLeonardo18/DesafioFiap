using Dapper.Contrib.Extensions;

namespace Domain.Entities
{
    [Table("[Aluno]")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "O nome é obrigatório!")]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string Nome { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "O Usuário é obrigatório!")]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string Usuario { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "A senha é obrigatório!")]
        public string senha { get; set; }

        public bool Ativo { get; set; }
    }
}
