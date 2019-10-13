using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineVideoGamePortal.Models;



namespace OnlineVideoGamePortal.Pages
{
    public class StartPurchaseModel : PageModel
    {



        private readonly OnlineVideoGamePortalContext _context;
        public StartPurchaseModel(OnlineVideoGamePortalContext context)
        {
            _context = context;
        }
        [BindProperty]
        public StartPurchaseForm StartPurchaseForm { get; set; }
        public void OnGet()
        {
            PopulateSelectLists();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                PopulateSelectLists();
                return Page();
            }



            var purchase = new Purchase();
            purchase.VideoGameID = StartPurchaseForm.VideoGameID.Value;
            purchase.GamerID = StartPurchaseForm.GamerID.Value;
            purchase.AmountPaid = StartPurchaseForm.AmountPaid;
            purchase.ModeOfTransaction = StartPurchaseForm.ModeOfTransaction;
            _context.Purchase.Add(purchase);
            _context.SaveChanges();
            return RedirectToPage("/Purchases/Index");
        }





        private void PopulateSelectLists()
        {

            var gamers = _context.GamerInfo
                                 .Where(x => x.IsActiveCustomer == true)
                                 .OrderBy(x => x.Name)
                                 .ToList();

            ViewData["ID"] = new SelectList(gamers, "ID", "Name");



            var videogames = _context.VideoGame
                                 .Where(x => x.IsAvailable == true)
                                 .OrderBy(x => x.Title)
                                 .ToList();



            ViewData["VideoGameID"] = new SelectList(videogames, "VideoGameID", "Title");
        }



    }
}