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
            // List<Reservation> listOfAvailableRooms = new List<Reservation>();
            var listOfAvailableRooms = this.objGuestDetails.getListOFAvailableRoom().ToList();
            ViewBag.listOfRooms = listOfAvailableRooms;

            return View();
        }


        [HttpPost]
        //This binds the data to GuestDetails Model and passes the info into the Repo 
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
                //catches exception if there's any
                var mess = ex.Message;
            }
            return RedirectToAction("ReturnForm");
        }

        //this action method returns the ReturnForm razor view after successful checkin
        public IActionResult ReturnForm()
        {
            return View();
        }

    }
}
