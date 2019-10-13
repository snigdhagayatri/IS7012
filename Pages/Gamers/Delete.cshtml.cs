using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Gamers
{
    public class DeleteModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public DeleteModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GamerInfo GamerInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GamerInfo = await _context.GamerInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (GamerInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GamerInfo = await _context.GamerInfo.FindAsync(id);

            if (GamerInfo != null)
            {
                _context.GamerInfo.Remove(GamerInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
