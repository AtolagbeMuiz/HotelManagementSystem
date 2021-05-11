using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class HotelManagementDBContext : DbContext
    {
        public HotelManagementDBContext(DbContextOptions<HotelManagementDBContext> options)
            : base(options)
        {

        }

        public DbSet<GuestDetails> Guest { get; set; }

        public DbSet<HotelRoom> Room { get; set; }
    }
}
