using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.ViewComponents
{
    public class MembershipViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Membership");
        }
    }
}
