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
    public class DetailsModel : PageModel
    {
        private readonly OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext _context;

        public DetailsModel(OnlineVideoGamePortal.Models.OnlineVideoGamePortalContext context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoGame = await _context.VideoGame.FirstOrDefaultAsync(m => m.VideoGameID == id);

            if (VideoGame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
