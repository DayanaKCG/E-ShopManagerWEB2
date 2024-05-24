using E_ShopManagerWEB2.Data;
using E_ShopManagerWEB2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E_ShopManagerWEB2.Pages.Productos
{
    public class EditModel : PageModel
    {
		private readonly E_ShopManagerContext _context;
		public EditModel(E_ShopManagerContext context)
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
			Producto = producto;
			return Page();
		}
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_context.Attach(Producto).State = EntityState.Modified;
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ProductoExists(Producto.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return RedirectToPage("./Index");
		}
		private bool ProductoExists(int id)
		{
			return (_context.Productos?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}