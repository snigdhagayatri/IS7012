using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Gamers
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
            return Page();
        }

        [BindProperty]
        public GamerInfo GamerInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GamerInfo.Add(GamerInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}