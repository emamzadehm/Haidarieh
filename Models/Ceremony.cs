using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class Ceremony
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CeremonyDate { get; private set; }
        public bool Status { get; private set; }
        public List<CeremonyGuest> CeremonyGuests { get; private set; }

        public Ceremony(string title,DateTime ceremonyDate)
        {
            Title = title;
            Status = true;
            CeremonyDate = ceremonyDate;
            CeremonyGuests = new List<CeremonyGuest>();
        }

    }
}
