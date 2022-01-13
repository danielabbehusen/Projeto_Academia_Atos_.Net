using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal01.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int idProfessor { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CREF")]
        [Display(Name = "CREF")]
        public string CREF { get; set; }

        

    }
}
