using E_ShopManagerWEB2.Data;
using E_ShopManagerWEB2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E_ShopManagerWEB2.Pages.Productos
{
    public class DeleteModel : PageModel
    {
		private readonly E_ShopManagerContext _context;
		public DeleteModel(E_ShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]
		public Producto Producto { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Productos == null)
			{
				return NotFound();
			}
			var producto = await _context.Productos.FirstOrDefaultAsync(m => m.Id == id);
			if (producto == null)
			{
				return NotFound();
			}
			else
			{
				Producto = producto;
				_context.Productos.Remove(producto);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}
	}
}