using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.ViewComponents
{
    public class SponsorsViewComponent:ViewComponent
    {
        private readonly SponsorOperations _sponsorOperations;

        public SponsorsViewComponent(SponsorOperations sponsorOperations)
        {
            _sponsorOperations = sponsorOperations;
        }

        public IViewComponentResult Invoke()
        {
            var sopnsers = _sponsorOperations.GetAll();
            return View("_Sponsors", sopnsers);
        }
    }
}
