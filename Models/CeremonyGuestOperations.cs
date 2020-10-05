using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class CeremonyGuestOperations
    {
        private readonly EfContext _efcontext;

        public CeremonyGuestOperations(EfContext efcontext)
        {
            _efcontext = efcontext;
        }
        public List<CeremonyGuest> GetComing()
        {
            return _efcontext.CeremonyGuests
                .Include(x => x.Ceremony)
                .Include(x => x.Guest)
                .Include(x=>x.Multimedias)
                .Where(x => x.CeremonyDate >= DateTime.Now).ToList();
        }
        public List<CeremonyGuest> GetPast()
        {
            return _efcontext.CeremonyGuests
                .Include(x => x.Ceremony)
                .Include(x => x.Guest)
                .Include(x => x.Multimedias)
                .Where(x => x.CeremonyDate < DateTime.Now).ToList();
        }
        public List<CeremonyGuest> GetAll()
        {
            return _efcontext.CeremonyGuests
                .Include(x => x.Ceremony)
                .Include(x => x.Guest)
                .Include(x => x.Multimedias).ToList();
        }

    }
}
