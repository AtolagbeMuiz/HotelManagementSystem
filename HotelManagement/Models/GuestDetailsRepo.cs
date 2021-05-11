using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class GuestDetailsRepo : IGuestDetails
    {
        private readonly HotelManagementDBContext _context;

        //Costructor that Initializes private field (_context) with the instance of DBContext class
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

        public IEnumerable<HotelRoom> getListOFAvailableRoom()
        {
            var listOfAvailableRooms = _context.Room.ToList();
            return listOfAvailableRooms;
        }
    }
}
