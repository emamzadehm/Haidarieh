using Microsoft.AspNetCore.Mvc;

using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.ViewComponents
{
    public class UpCommingViewComponent:ViewComponent
    {
        private readonly CeremonyGuestOperations _ceremonyGuestOperations;

        public UpCommingViewComponent(CeremonyGuestOperations ceremonyGuestOperations)
        {
            _ceremonyGuestOperations = ceremonyGuestOperations;
        }

        public IViewComponentResult Invoke()
        {
            var comingevents = _ceremonyGuestOperations.GetComing();
            return View("_UpComming",comingevents);
        }

    }
}
