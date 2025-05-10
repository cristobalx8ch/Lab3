using System.ComponentModel.DataAnnotations;


namespace probando.Models.domain
{
    // clase que  representa un tipo de envasado para los productos
    public class Envasado
    {

        //propiedad  que representa el nombre del tipo envasado

        [Required]  // indica que el nombre es obligatorio  
        [StringLength(100)] // limita la longitud maxima a 100 caracteres
        [Display(Name = "Nombre del Envasado")] // etiqueta  se muestra en la interfaz de usuario
        public string Nombre {  get; set; }


        [Required]  // indica que la descripcion es obligatoria  
        [StringLength(100)]
        [Display(Name ="Descripcion del envasado")] 
        public string Descripcion { get; set; } 
        
    }
}
