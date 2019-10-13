using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineVideoGamePortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace OnlineVideoGamePortal.Pages
{
    public class GamersProfileModel : PageModel
    {
        private OnlineVideoGamePortalContext _context;
        public GamersProfileModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }
        public ICollection<GamerInfo> Gamers { get; set; }
        public void OnGet()
        {
            Gamers = _context.GamerInfo.Include(mob => mob.Purchases).OrderBy(x => x.ID).ToList();

        }
    }
}