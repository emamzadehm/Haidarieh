using System;
using System.Collections.Generic;

namespace WebApplicationEFCore.Models
{
    
    public class CeremonyGuest
    {
        public long Id { get;  set; }
        public long CeremonyId { get;  set; }
        public long GuestId { get;  set; }
        public DateTime CeremonyDate { get;  set; }
        public float Satisfication { get;  set; }
        public bool IsLive { get;  set; }
        public string BannerFile { get;  set; }
        public bool Status { get;  set; }
        public string Image { get;  set; }
        public Guest Guest { get;  set; }
        public Ceremony Ceremony { get;  set; }
        public List<Multimedia> Multimedias { get;  set; }


        public CeremonyGuest(long ceremonyId, long guestId, DateTime ceremonyDate, float satisfication)
        {
            CeremonyId = ceremonyId;
            GuestId = guestId;
            CeremonyDate = ceremonyDate;
            Satisfication = satisfication;
            Status = true;
            Multimedias = new List<Multimedia>();

        }

    }
}
