namespace E_ShopManagerWEB2.Models
{
	public class Cliente
	{
		public int Id { get; set; } // PK LLave

		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Email { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; }

		public ICollection<Pedido>? Pedidos { get; set; } = default!;
	}
}
