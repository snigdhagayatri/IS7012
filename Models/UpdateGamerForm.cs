using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace OnlineVideoGamePortal.Models
{
    public class UpdateGamerForm
    {



        public UpdateGamerForm()
        {
            PreferredVideoGame = null;
            FavGame = null;
        }
        public int GamerID { get; set; }



        [Display(Name = "Active User")]
        public bool IsActiveCustomer { get; set; }



        [StringLength(250)]
        [Display(Name = "Preferred Video Game")]
        public string PreferredVideoGame { get; set; }



        [StringLength(250)]
        [Display(Name = "Favourite Game")]
        public string FavGame { get; set; }
    }
}