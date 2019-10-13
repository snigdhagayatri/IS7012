using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;



namespace OnlineVideoGamePortal.Pages
{
    public class UpdateGamerModel : PageModel
    {



        private readonly OnlineVideoGamePortalContext _context;
        public UpdateGamerModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }



        [BindProperty]
        public UpdateGamerForm UpdateGamerForm { get; set; }



        public GamerInfo GamerInfo { get; set; }



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GamerInfo = await _context.GamerInfo
                                        .Include(a => a.Purchases)
                                        .FirstOrDefaultAsync(gamr => gamr.ID == id);




            if (GamerInfo == null)
            {
                return NotFound();
            }


            UpdateGamerForm = new UpdateGamerForm();
            UpdateGamerForm.GamerID = GamerInfo.ID;



            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {



            if (!ModelState.IsValid)
            {
                return Page();
            }

            GamerInfo = await _context.GamerInfo.FindAsync(UpdateGamerForm.GamerID);
            GamerInfo.IsActiveCustomer = UpdateGamerForm.IsActiveCustomer;
            GamerInfo.PreferredVideoGame = UpdateGamerForm.PreferredVideoGame;
            GamerInfo.FavGame = UpdateGamerForm.FavGame;



            await _context.SaveChangesAsync();
            return RedirectToPage("/Gamers/Index");

        }
    }
}