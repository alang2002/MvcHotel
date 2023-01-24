using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcHotel.Models;

namespace MvcHotel.Data
{
    public class MvcHotelContext : DbContext
    {
        public MvcHotelContext (DbContextOptions<MvcHotelContext> options)
            : base(options)
        {
        }

        public DbSet<MvcHotel.Models.Guest> Guest { get; set; } = default!;
    }
}
