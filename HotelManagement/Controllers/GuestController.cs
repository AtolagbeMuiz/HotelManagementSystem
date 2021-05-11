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
        [HttpGet]
        public IActionResult RegisterGuestDetails()
        {
            List<HotelRoom> listOfAvailableRooms = new List<HotelRoom>();
            listOfAvailableRooms = this.objGuestDetails.getListOFAvailableRoom().ToList();
            ViewBag.listOfRooms = listOfAvailableRooms;

            return View();
        }

        [HttpPost]
        public IActionResult RegisterGuestDetails(GuestDetails guestDetails)
        {
            try
            {
                //Validates the GuestDetails Model
                if (ModelState.IsValid)
                {
                    var details = this.objGuestDetails.registerGuest(guestDetails);
                }
            }
            catch (Exception ex)
            {

                var mess = ex.Message;
            }
            return RedirectToAction("RegisterGuestDetails");
        }

    }
}
