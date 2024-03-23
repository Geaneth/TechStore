using System.ComponentModel.DataAnnotations;
namespace TechStore.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }


        [Required, Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

         [StringLength(500)]
        public string Descripcion { get; set; }

       public decimal CalcularIGV()
        {
            return Precio * 0.18m; 
        }
    }
}