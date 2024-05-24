using System.ComponentModel.DataAnnotations.Schema;

namespace E_ShopManagerWEB2.Models
{
	public class Producto
	{
		public int Id { get; set; } //Llave PK

		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		[Column(TypeName = "decimal(6,2)")]
		public decimal Precio { get; set; }

		public int Stock { get; set; }
		public int CategoriaId { get; set; } // (FK)
		public Categoria? Categoria { get; set; } = default!; //Navegacion
		public string ImagenUrl { get; set; }

		public ICollection<DetallePedido>? DetallePedidos { get; set; } = default!; // Propie Navegacion
	}
}
