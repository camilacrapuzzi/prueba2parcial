using System.ComponentModel.DataAnnotations;

namespace CancionesWebApi.Models
{
    public class Cancion
    {
        [Key]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="{0} es requerido")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "{0} es requerido")]
        [StringLength(200,MinimumLength =10, ErrorMessage = "La longitud de{0} debe estar entre {2} y {1}")]
        public string Letra { get; set; }
        [Url]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La longitud de{0} debe estar entre {2} y {1}")]
        public string Enlace { get; set; }

    }
}

