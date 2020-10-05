using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class Sponsor
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Tel { get; private set; }
        public string Image { get; private set; }
        public bool Status { get; private set; }
        public bool IsVisible { get; private set; }
        public string Bio { get; private set; }

    }
}
