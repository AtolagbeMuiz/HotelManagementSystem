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

        //This Method Add Guest Details into the Database
        public GuestDetails registerGuest(GuestDetails guestDetails)
        {
            //sets RoomisAvailable to false while adding guest details to DB
            guestDetails.RoomisAvailable = false;
           
            _context.Guest.Add(guestDetails);
            _context.SaveChanges();

            HotelRoom room = new HotelRoom();
            Reservation res = new Reservation();

            //LINQ query to return true if the selected room is available
            var result = _context.Reservation.Any(x => x.RoomName == guestDetails.AvailableRooms);

           if (result)
            {
                //Initilizes the reservation details with guest details
                res.GuestID = guestDetails.GuestID;
                res.RoomisAvailable = guestDetails.RoomisAvailable;
                res.RoomName = guestDetails.AvailableRooms;
   
                //updates the Reservation with the guest that checked in to the room
                var reservationDetails = _context.Reservation.Attach(res);
                reservationDetails.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                //reservationDetails.Entry(res).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            return guestDetails;
        }


        //Returns list of Available rooms
        public IEnumerable<Reservation> getListOFAvailableRoom()
        {
            var listOfAvailableRooms = _context.Reservation.Where(x => x.RoomisAvailable == true).ToList();
            return listOfAvailableRooms;
        }
    }
}
