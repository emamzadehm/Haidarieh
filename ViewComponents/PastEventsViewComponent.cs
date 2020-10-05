using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.ViewComponents
{
    public class PastEventsViewComponent:ViewComponent
    {
        private readonly CeremonyGuestOperations _ceremonyGuestOperations;

        public PastEventsViewComponent(CeremonyGuestOperations ceremonyGuestOperations)
        {
            _ceremonyGuestOperations = ceremonyGuestOperations;
        }
        public IViewComponentResult Invoke()
        {
            var pastevents = _ceremonyGuestOperations.GetPast();
            return View("_PastEvents",pastevents);
        }
    }
}
