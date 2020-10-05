using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.Controllers
{
    public class CeremonyGuestController : Controller
    {
        private readonly CeremonyGuestOperations _ceremonyGuestOperations;

        public CeremonyGuestController(CeremonyGuestOperations ceremonyGuestOperations)
        {
            _ceremonyGuestOperations = ceremonyGuestOperations;
        }

        public IActionResult Index()
        {

            var ceremonies = _ceremonyGuestOperations.GetPast();

            return View(ceremonies);
        }


    }
}
