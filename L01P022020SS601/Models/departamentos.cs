using System.ComponentModel.DataAnnotations;

namespace L01P022020SS601.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nombre de el departamento")]
        [Required(ErrorMessage = "El nombre de el departamento No es opcional")]
        public string? departamento { get; set; }
    }
}
