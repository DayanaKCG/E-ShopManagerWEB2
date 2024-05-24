using E_ShopManagerWEB2.Data;
using E_ShopManagerWEB2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E_ShopManagerWEB2.Pages.Categorias
{
	public class IndexModel : PageModel
	{
		private readonly E_ShopManagerContext _context;

		public IndexModel(E_ShopManagerContext context)
		{
			_context = context;
		}
		public IList<Categoria> Categorias { get; set; } = default!;
		public async Task OnGetAsync()
		{
			if (_context.Categorias != null)
			{
				Categorias = await _context.Categorias.ToListAsync();
			}
		}
	}
}