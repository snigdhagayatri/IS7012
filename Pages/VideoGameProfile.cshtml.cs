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
    public class VideoGameProfileModel : PageModel
    {
        private OnlineVideoGamePortalContext _context;
        public VideoGameProfileModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }
       // public VideoGame VideoGame { get; set; }
        public ICollection<VideoGame> VideoGame { get; set; }
        public IActionResult OnGet(int? id)
        {
            VideoGame = _context.VideoGame.Include(x => x.Purchase).OrderBy(x => x.ReleaseDate).ToList();
            return Page(); 
        }
    }

   
}