using System.ComponentModel.DataAnnotations.Schema;

namespace E_ShopManagerWEB2.Models
{
	public class DetallePedido
	{
		public int Id { get; set; } // Llave
		public int PedidoId { get; set; } // FK
		public int ProductoId { get; set; } //FK
		public int Cantidad { get; set; }

		[Column(TypeName = "decimal(6,2)")]
		public decimal Precio { get; set; }

		public Pedido Pedido { get; set; } = default!;// Navegacion
		public Producto Producto { get; set; } = default!;// Navegacion

		

	}
}