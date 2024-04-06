using System.ComponentModel.DataAnnotations;
namespace L01P022020SS601.Models

{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de la materia")]       
        public string materia { get; set; }

        [Display(Name = "Unidades Valorativas")]
        public int unidades_valorativas { get; set; }
        [Display(Name = "estado")]
        [Required(ErrorMessage = "El  estado No es opcional")]
        public string estado { get; set; }
        }
}
