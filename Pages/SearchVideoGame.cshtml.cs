using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineVideoGamePortal.Models;



namespace OnlineVideoGamePortal.Pages
{
    public class SearchVideoGameModel : PageModel
    {
        private OnlineVideoGamePortalContext _context;





        public SearchVideoGameModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }



        public void OnGet()
        {
            SearchCompleted = false;
        }



        [BindProperty]
        public string Search { get; set; }

        public bool SearchCompleted { get; set; }



        public ICollection<VideoGame> SearchResults { get; set; }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(Search))
            {
                return;
            }
            SearchResults = _context.VideoGame
                                    .Where(x => x.Title.ToLower().Contains(Search.ToLower()))
                                    .ToList();
            SearchCompleted = true;
        }
    }
}