using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Purchases
{
    public class DeleteModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public DeleteModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Purchase = await _context.Purchase
                .Include(p => p.VideoGame).FirstOrDefaultAsync(m => m.PurchaseID == id);

            if (Purchase == null)
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

            Purchase = await _context.Purchase.FindAsync(id);

            if (Purchase != null)
            {
                _context.Purchase.Remove(Purchase);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
