using E_ShopManagerWEB2.Data;
using E_ShopManagerWEB2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_ShopManagerWEB2.Pages.DetallePedidos
{
    public class CreateModel : PageModel
    {
		private readonly E_ShopManagerContext _context;
		public CreateModel(E_ShopManagerContext context)
		{
			_context = context;
		}
		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public DetallePedido DetallePedido { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.DetallePedidos == null || DetallePedido == null)
			{
				return Page();
			}
			_context.DetallePedidos.Add(DetallePedido);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
