using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineVideoGamePortal.Models
{
    public class VideoGame
    {
        [Required ]
        [Range(0, 365)]
        public int VideoGameID { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string Title { get; set; }
        [Required]
        public decimal Version { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [CustomValidation(typeof(VideoGame), "NameValidation")]
        [CustomValidation(typeof(VideoGame), "ReleaseDateValidation")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Memory Space")]
        public int MemorySpace { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string Description { get; set; }
        [Display(Name = "Sports Game")]
        public bool IsSportsGame { get; set; }
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }

        public ICollection <Purchase> Purchase
        {
            get; set;
        }
        public static ValidationResult ReleaseDateValidation(DateTime? releaseDate, ValidationContext context)
        {
            if (releaseDate == null)
            {
                return ValidationResult.Success;
            }
            if (releaseDate.Value.Date <= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            string errorMessage = $"Video Game Release date must be a date on or before { DateTime.Today.ToShortDateString() }";
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
            return ValidationResult.Success;
        }
    }
}

