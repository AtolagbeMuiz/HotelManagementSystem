using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class HotelRoom
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomName { get; set; }
    }
}
