using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;

namespace OnlineVideoGamePortal.Pages.VideoGames
{
    public class IndexModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public IndexModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get;set; }

        public async Task OnGetAsync()
        {
            VideoGame = await _context.VideoGame.ToListAsync();
        }
    }
}
