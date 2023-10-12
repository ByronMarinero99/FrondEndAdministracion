using System.ComponentModel.DataAnnotations;

namespace FrontenAdministracion.Models
{
    public class Juego
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La clasificacion es requerido")]
        public int TipoGenerosId { get; set; }

        [Required(ErrorMessage = "El titulo es requerido")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        public string Img { get; set; }

        [Required(ErrorMessage = "El nombre es requerida")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La plataforma es requerido")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "el genero es requerido")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "el formato es requerido")]
        public string Formato { get; set; }

        [Required(ErrorMessage = "El formato es requerida")]
        public string size { get; set; }

        [Required(ErrorMessage = "La Fecha es requerida")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "La version es requerida")]
        public string Version { get; set; }

        public Categoria TipoGenero { get; set; }
    }
}
