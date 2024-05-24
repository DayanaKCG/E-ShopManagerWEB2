using E_ShopManagerWEB2.Models;
using Microsoft.EntityFrameworkCore;

namespace E_ShopManagerWEB2.Data

{
	public class E_ShopManagerContext : DbContext
	{
		public E_ShopManagerContext(DbContextOptions<E_ShopManagerContext> options) : base(options)
		{
		}
		public DbSet<Producto> Productos { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<DetallePedido> DetallePedidos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=(localdb)\\mssqllocaldb;Database=E-ShopManager2;Trusted_Connection=True;");
		}
	}
}