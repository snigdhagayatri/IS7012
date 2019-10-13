using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineVideoGamePortal.Models
{
    public class GamerInfo
    {
        [Range(0, 365)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        [CustomValidation(typeof(GamerInfo), "NameValidation")]
        public string Name { get; set; }
        [Required]
        [CustomValidation(typeof(GamerInfo), "AgeValidation")]
        public int Age { get; set; }
        [StringLength(250)]
        [Display(Name = "Preferred Video Game")]
        public string PreferredVideoGame { get; set; }
        [Display(Name = "Games Purchased")]
        public string GamesPurchased { get; set; }
        [StringLength(250)]
        [Display(Name = "Favourite Game")]
        public string FavGame { get; set; }
        [CustomValidation(typeof(GamerInfo), "JoiningDateDateValidation")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Joined")]
        public DateTime? DateJoined { get; set; }
        [Display(Name = "Active")]
        public bool IsActiveCustomer { get; set; }

        public ICollection<Purchase> Purchases
        {
            get; set;
        }
        public static ValidationResult JoiningDateDateValidation(DateTime? joiningDate, ValidationContext context)
        {
            if (joiningDate == null)
            {
                return ValidationResult.Success;
            }
            if (joiningDate.Value.Date <= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            string errorMessage = $"Gamer Joining date must be a date on or before { DateTime.Today.ToShortDateString() }";
            return new ValidationResult(errorMessage);
        }
        public static ValidationResult AgeValidation(int a, ValidationContext context)
        {
            if (a > 0)
            {
                 return ValidationResult.Success;
            }
            string errorMessage = $"Gamer Age Should not be 0 or less than 0";
            return new ValidationResult(errorMessage);
        }

        public static ValidationResult NameValidation(string name, ValidationContext context)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as VideoGame;
            if (instance == null)
            {
                return ValidationResult.Success;
            }

            var dbContext = context.GetService(typeof(OnlineVideoGamePortalContext)) as OnlineVideoGamePortalContext;

            int duplicateCount = dbContext.VideoGame
                                          .Count(x => x.VideoGameID != instance.VideoGameID && x.Title == name);
            if (duplicateCount > 0)
            {
                return new ValidationResult($"Name {name} already exists");
            }
            return ValidationResult.Success;
        }
    }
}
