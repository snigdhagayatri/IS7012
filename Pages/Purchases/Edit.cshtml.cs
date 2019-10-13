using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Purchases
{
    public class EditModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public EditModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
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
            ViewData["ID"] = new SelectList(_context.GamerInfo, "ID", "Name");
            ViewData["VideoGameID"] = new SelectList(_context.VideoGame, "VideoGameID", "Title");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Purchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(Purchase.PurchaseID))
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

        private bool PurchaseExists(int id)
        {
            return _context.Purchase.Any(e => e.PurchaseID == id);
        }
    }
}
