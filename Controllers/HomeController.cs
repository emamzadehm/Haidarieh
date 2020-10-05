using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly EfContext _efContext;
        //public HomeController(EfContext efContext)
        //{
        //    _efContext = efContext;
        //}
        //private readonly CeremonyGuest _ceremonyGuest;

       // public HomeController(CeremonyGuest ceremonyGuest)
        //{
            //_ceremonyGuest = ceremonyGuest;
       // }

        public IActionResult Index()
        {
            //var Ceremony = new Ceremony("عاشورا",DateTime.Now);
            //_efContext.Tbl_Ceremonies.Add(Ceremony);

            //var Ceremony1 = new Ceremony("تاسوعا", new DateTime(2020 / 01 / 01));
            //_efContext.Tbl_Ceremonies.Add(Ceremony1);

            //var Ceremony2 = new Ceremony("غدیر", new DateTime(2019 / 01 / 05));
            //_efContext.Tbl_Ceremonies.Add(Ceremony2);

            //_efContext.SaveChanges();

            //var record=_efContext.Tbl_Ceremonies.FirstOrDefault(x=>x.Id==20);
            //var record1 = _efContext.Ceremonies.Where(cer => cer.Status != false).ToList();

            //var ceremonies = _efContext.CeremonyGuests.ToList();
            
            //var ceremonies= _ceremonyGuestOperations.GetAll();
                        
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string ConvertMiladitoShamsi(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return (pc.GetYear(dt) + "/" + pc.GetMonth(dt) + "/" + pc.GetDayOfMonth(dt));

        }
    }
}
