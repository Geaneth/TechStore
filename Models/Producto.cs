using System.ComponentModel.DataAnnotations;
namespace TechStore.Models
{
    public class Producto
    {
          public int Id { get; set; }
         [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int Precio { get; set; }
         public decimal igv { get; set; }
        public decimal CalcularIGV()
        {
            return Precio * 0.18m; 
        }

    }
}
