using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineVideoGamePortal.Models;


namespace OnlineVideoGamePortal.Pages
{
    public class IndexModel : PageModel
    {
        private OnlineVideoGamePortalContext _context;
        public IndexModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }
        public int CountOfVideoGames { get; set; }
        public int CountOfGamers { get; set; }
        public int CountOfPurchases { get; set; }
        public int CountOfDifferentGames { get; set; }
        public void OnGet()
        {
            CountOfVideoGames = _context.VideoGame.Count();
            CountOfGamers = _context.GamerInfo.Count();
            CountOfPurchases = _context.Purchase.Count();
            CountOfDifferentGames = _context.VideoGame.GroupBy(x => x.Title).Count();

        }
    }
}
