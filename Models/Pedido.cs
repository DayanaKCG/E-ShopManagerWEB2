using System.ComponentModel.DataAnnotations.Schema;

namespace E_ShopManagerWEB2.Models
{
	public class Pedido
	{
		public int Id { get; set; } //Llave
		public int? ClienteId { get; set; } // (FK)
		public DateTime FechaPedido { get; set; }
		[Column(TypeName = "decimal(10,2)")]
		public decimal Total { get; set; }
		public string Estado { get; set; }

		public Cliente? Cliente { get; set; } = default!; //Navegacion
		public ICollection<DetallePedido>? DetallesPedido { get; set; } = default!;
	}
}