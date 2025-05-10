using System.ComponentModel.DataAnnotations;

namespace probando.Models.domain
{

    // Hereda de la clase Producto y agrega propiedades relacionadas con la fecha de vencimiento del producto.
    public class ProductoPerecible : Producto
    {


          // Es obligatoria y debe ser de tipo DateTime.
          // Se utiliza para establecer cuándo el producto caduca.
        [Required]  // Indica que la fecha de vencimiento es obligatoria.
        [Display(Name = "Fecha de Vencimiento")]    // Etiqueta que se muestra en la interfaz de usuario.
        [DataType(DataType.Date)]   // Especifica que la entrada debe ser un tipo de dato de fecha.
        public DateTime FechaDeVencimiento { get; set; }



        // propiedad que calcula los dias  para que el producto venza
        // se calcula  como la diferencia entre la fecha de vencimineto y la fecha actual
        [Display(Name = "Dias para vencer")]    // Etiqueta que se muestra en la interfaz de usuario.
        public int DiasParaVencer
        {
            get
            {
                return (FechaDeVencimiento - DateTime.Now).Days;    //resta la fecha actual  de la fecha de vencimiento y devuelve en dias 
            }
            private set { } // la propiedad no se puede modificar directamente, calcula automaticamente
        }
    }
}
