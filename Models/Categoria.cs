using System.ComponentModel.DataAnnotations;

namespace FrontenAdministracion.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Tipo { get; set; }
    }
}
