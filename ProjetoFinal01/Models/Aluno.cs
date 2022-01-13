using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal01.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int idAluno { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [ForeignKey("Professor")]
        [Column("profId")]
        [Display(Name = "Professor")]
        public int professorID { get; set; }

        public virtual Professor Professor { get; set; }
    }
}
