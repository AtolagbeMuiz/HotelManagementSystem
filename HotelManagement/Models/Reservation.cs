using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class Reservation 
    {
        [Key]
        public int ReservationID { get; set; }

       
        public int? GuestID { get; set; }

        [ForeignKey("RoomID")]
        public int RoomID { get; set; }

        [ForeignKey("RoomName")]
        public string RoomName { get; set; }

        [ForeignKey("RoomisAvailable")]
        public bool RoomisAvailable { get; set; } = false;
    }
}
