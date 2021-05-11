using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class GuestDetails
    {
        [Key]
        public int GuestID { get; set; }

        [Required]
        public string GuestName { get; set; }

        [Required]
        public string GuestAddress { get; set; }

        [Required]
        public int AvailableRooms { get; set; }

        [Required]
        public DateTime CheckinDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime CheckoutDate { get; set; }
    }
}
