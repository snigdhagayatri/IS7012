using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineVideoGamePortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineVideoGamePortal.Pages
{
    public class PurchaseDetailsModel : PageModel
    {
        private OnlineVideoGamePortalContext _context;
        public PurchaseDetailsModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }
        public Purchase Purchases { get; set; }

        public IActionResult OnGet(int? purchaseId)
        {
            Purchases = _context.Purchase.Include(mob => mob.GamerInfo)
                                         .Include(vg => vg.VideoGame)
                                         .Where(x => x.PurchaseID == purchaseId)
                                         .FirstOrDefault();
            if (Purchases == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}