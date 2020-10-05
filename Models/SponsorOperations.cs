using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class SponsorOperations
    {
        private readonly EfContext _efContext;

        public SponsorOperations(EfContext efContext)
        {
            _efContext = efContext;
        }

        public List<Sponsor> GetAll()
        {
            return _efContext.Sponsors.ToList();
        }
    }

}
