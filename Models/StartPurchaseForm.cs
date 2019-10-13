using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace OnlineVideoGamePortal.Models
{
    public class StartPurchaseForm
    {



        [Display(Name = "Video Game")]
        [Required(ErrorMessage = "Please select a video game")]
        [CustomValidation(typeof(StartPurchaseForm), "ValidateGame")]
        public int? VideoGameID { get; set; }

        [Display(Name = "Gamer")]
        [Required(ErrorMessage = "Please select gamer")]
        [CustomValidation(typeof(StartPurchaseForm), "ValidateGamer")]
        public int? GamerID { get; set; }



        [DataType(DataType.Currency)]
        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }



        [Display(Name = "Mode Of Trasaction")]
        public string ModeOfTransaction { get; set; }




        public static ValidationResult ValidateGame(int? videogameId, ValidationContext context)
        {
            if (videogameId == null)
            {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(OnlineVideoGamePortalContext)) as OnlineVideoGamePortalContext;
            var videogame = dbContext.VideoGame
                                         .Include(x => x.Purchase)
                                         // .Include(x => x.Gamers)
                                         .FirstOrDefault(x => x.VideoGameID == videogameId.Value);
            if (videogame == null)
            {
                return new ValidationResult("Please select a valid establishment");
            }
            if (!videogame.IsAvailable)
            {
                return new ValidationResult("This video game is not available");
            }

            return ValidationResult.Success;
        }



        public static ValidationResult ValidateGamer(int? gamerId, ValidationContext context)
        {
            if (gamerId == null)
            {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(OnlineVideoGamePortalContext)) as OnlineVideoGamePortalContext;
            var gamer = dbContext.GamerInfo.FirstOrDefault(x => x.ID == gamerId.Value);
            if (gamer == null)
            {
                return new ValidationResult("Please select a valid gamer");
            }
            if (!gamer.IsActiveCustomer)
            {
                return new ValidationResult("This gamer is not currently active");
            }
            return ValidationResult.Success;
        }
    }
}