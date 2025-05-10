using System.ComponentModel.DataAnnotations;


namespace probando.Models.domain
{
    public class ProductoNoPerecible : Producto
    {

        [Required]  // Indica que el tipo de envasado es obligatorio.
        [Display(Name = "Tipo de Envasado")]    // Etiqueta que se muestra en la interfaz de usuario.
        public Envasado TipoDeEnvasado { get; set; }
    }
}
