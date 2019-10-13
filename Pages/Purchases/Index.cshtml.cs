﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.Purchases
{
    public class IndexModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public IndexModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        public IList<Purchase> Purchase { get;set; }

        public async Task OnGetAsync()
        {
            Purchase = await _context.Purchase
                .Include(p => p.GamerInfo)
                .Include(p => p.VideoGame).ToListAsync();
        }
    }
}
