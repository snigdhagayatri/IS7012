using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineVideoGamePortal.Models;
using OnlineVideoGamePortal.Pages;

namespace OnlineVideoGamePortal.Models
{
    public class OnlineVideoGamePortalContext : DbContext
    {
        public OnlineVideoGamePortalContext (DbContextOptions<OnlineVideoGamePortalContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineVideoGamePortal.Models.VideoGame> VideoGame { get; set; }

        public DbSet<OnlineVideoGamePortal.Models.Purchase> Purchase { get; set; }

        public DbSet<OnlineVideoGamePortal.Models.GamerInfo> GamerInfo { get; set; }

        public static implicit operator OnlineVideoGamePortalContext(VideoGameProfileModel v)
        {
            throw new NotImplementedException();
        } 
    }
}
