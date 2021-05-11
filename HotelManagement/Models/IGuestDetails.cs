using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public interface IGuestDetails
    {
        public GuestDetails registerGuest(GuestDetails guestDetails);

        public IEnumerable<HotelRoom> getListOFAvailableRoom();
    }
}
