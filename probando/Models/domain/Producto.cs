using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace probando.Models.domain
{
    public class Producto
    {
        [Required] // indica que el nombre es obligatorio  
        [StringLength(100)]     // limita la longitud maxima a 100 caracteres
        [Display(Name = "Nombre del producto")]     // etiqueta  se muestra en la interfaz de usuario
        public string Nombre { get; set; }

        [Required] // indica que el codigoDeBarra es obligatorio  
        [StringLength(50)]  // limita la longitud maxima a 50 caracteres
        [Display(Name = "Codigo de Barra")]      // etiqueta  se muestra en la interfaz de usuario
        public string CodigoDeBarra { get; set; }

        [Required]  // Indica que el precio es obligatorio.
        [Display(Name = "Precio")]  // Etiqueta que se muestra en la interfaz de usuario.
        public int Precio { get; set; }

        [Required]
        [Display(Name = "Cantidad disponible")]
        public int CantidadDisponible { get; set; }


        //Se muestra como un valor booleano(verdadero o falso), pero no es obligatoria.
        [Display(Name = "Disponible")]  // Etiqueta que se muestra en la interfaz de usuario.
        public bool Estado { get; set; }

        public Producto(){}
        public Producto(string nombre, string codigoDeBarra, int precio, int cantidadDisponible, bool estado)
        {
            Nombre = nombre;
            CodigoDeBarra = codigoDeBarra;
            Precio = precio;
            CantidadDisponible = cantidadDisponible;
            Estado = estado;
        }
    }
}
