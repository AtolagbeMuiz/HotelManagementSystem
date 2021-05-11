using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Models;

namespace HotelManagement.Controllers
{
    public class GuestController : Controller
    {

        private readonly IGuestDetails objGuestDetails;

        //Constructor
        public GuestController(IGuestDetails accesslayer)
        {
            this.objGuestDetails = accesslayer;
        }


        //This Returns the Guest Details Form view
        public IActionResult RegisterGuestDetails()
        {
            return View();
        }

        public IActionResult RegisterGuestDetails(GuestDetails guestDetails)
        {
            //Validates the GuestDetails Model
            if(ModelState.IsValid)
            {
                var details = this.objGuestDetails.registerGuest(guestDetails);
            }
            return View();
        }
    }
}
