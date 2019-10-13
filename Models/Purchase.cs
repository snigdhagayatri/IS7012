using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineVideoGamePortal.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }
        [Display(Name = "Mode Of Transaction")]
        public string ModeOfTransaction { get; set; }
        [Display(Name = "Gamer ID")]
        public int GamerID { get; set; }
        public GamerInfo GamerInfo { get; set; }
        public int VideoGameID { get; set; }
        [Display(Name = "Video Game")]
        public VideoGame VideoGame { get; set; }
    }
}
