using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_ShopManagerWEB2.Data;
using E_ShopManagerWEB2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace E_ShopManagerWEB2.Pages.DetallePedidos
{
    public class IndexModel : PageModel
    {
		private readonly E_ShopManagerContext _context;

		public IndexModel(E_ShopManagerContext context)
		{
			_context = context;
		}
		public IList<DetallePedido>? DetallePedidos { get; set; } 
		public async Task OnGetAsync()
		{
			if (_context.DetallePedidos != null)
			{
				DetallePedidos = await _context.DetallePedidos.ToListAsync();
			}
;
		}
	}
 }

