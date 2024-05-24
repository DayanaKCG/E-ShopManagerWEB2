namespace E_ShopManagerWEB2.Models
{
	public class Categoria
	{
		public int Id { get; set; } // Llave

		public string NombreCategoria { get; set; }
		public string Descripcion { get; set; }

		public ICollection<Producto>? Productos { get; set; } = default!;
	}
}