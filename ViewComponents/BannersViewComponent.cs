using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.ViewComponents
{
    public class BannersViewComponent: ViewComponent
    {
        private readonly CeremonyGuestOperations _ceremonyGuestOperations;

        public BannersViewComponent(CeremonyGuestOperations ceremonyGuestOperations)
        {
            _ceremonyGuestOperations = ceremonyGuestOperations;
        }

        public IViewComponentResult Invoke()
        {
            //var b1 = _efContext.CeremonyGuests.Where(x=>x.CeremonyDate>DateTime.Now).ToList();
            var b1 = _ceremonyGuestOperations.GetAll();
            return View("_Banners", b1);
        }

    }
}
