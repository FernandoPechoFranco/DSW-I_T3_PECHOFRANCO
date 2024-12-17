using System.ComponentModel.DataAnnotations;

namespace DSW_I_T3_PECHOFRANCO.Models
{
    public class Disco
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La capacidad es obligatoria")]
        [Display(Name = "Capacidad")]
        public string Capacidad { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Ancho")]
        public string Ancho { get; set; }

        [Display(Name = "Peso")]
        public string Peso { get; set; }

        [Display(Name = "Profundidad")]
        public string Profundidad { get; set; }

        [Required(ErrorMessage = "El tipo de disco es obligatorio")]
        [Display(Name = "Tipo de Disco")]
        public string Tipo { get; set; }
    }
}
