using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Purchases
{
    public class CreateModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public CreateModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ID"] = new SelectList(_context.GamerInfo, "ID", "Name");
            ViewData["VideoGameID"] = new SelectList(_context.VideoGame, "VideoGameID", "Title");
            return Page();
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Purchase.Add(Purchase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}