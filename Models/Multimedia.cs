using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class Multimedia
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string FileAddress { get; private set; }
        public bool Status { get; private set; }
        public long CeremonyGuestId { get; private set; }
        public CeremonyGuest CeremonyGuest { get; private set; }

        public Multimedia(string title, string fileAddress)
        {
            Title = title;
            FileAddress = fileAddress;
            Status = true;
        }
    }
}
