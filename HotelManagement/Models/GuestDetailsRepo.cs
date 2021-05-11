using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class GuestDetailsRepo : IGuestDetails
    {
        private readonly HotelManagementDBContext _context;

        public GuestDetailsRepo(HotelManagementDBContext context)
        {
            this._context = context;
        }
        public GuestDetails registerGuest(GuestDetails guestDetails)
        {
            _context.Guest.Add(guestDetails);
            _context.SaveChanges();
            return guestDetails;
        }
    }
}
