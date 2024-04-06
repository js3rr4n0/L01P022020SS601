using System.ComponentModel.DataAnnotations;
namespace L01P022020SS601.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nombre de la Facultad")]
        [Required(ErrorMessage = "El nombre de la Facultad No es opcional")]
        public string? facultad { get; set; }

    }
}
