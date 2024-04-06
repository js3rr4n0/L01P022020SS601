using System.ComponentModel.DataAnnotations;

namespace L01P022020SS601.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nombre de el departamento")]
        [Required(ErrorMessage = "El nombre de el departamento No es opcional")]
        public string? codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre No es opcional")]
        public string? nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El Apellido No es opcional")]
        public string? apellidos { get; set; }

        [Display(Name = "Dui")]
        public int dui { get; set; }
        [Display(Name = "Estado")]
        public int estado { get; set; }


    }
}
