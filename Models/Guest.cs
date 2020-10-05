using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class Guest
    {
        public long Id { get; private set; }
        public string FullName { get; private set; }
        public string Tel { get; private set; }
        public string Image { get; private set; }
        public string GuestType { get; private set; }
        public string Coordinator { get; private set; }
        public bool Status { get; private set; }
        public List<CeremonyGuest> CeremonyGuests { get; private set; }


        public Guest(string fullName, string tel, string guestType, string coordinator)
        {
            FullName = fullName;
            Tel = tel;
            GuestType = guestType;
            Coordinator = coordinator;
            Status = true;
            CeremonyGuests = new List<CeremonyGuest>();
        }
    }
}
