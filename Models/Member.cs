using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class Member
    {
        public long Id { get; private set; }
        public string FullName { get; private set; }
        public string Mobile { get; private set; }
        public bool Status { get; private set; }

        public Member(string fullName, string mobile)
        {
            FullName = fullName;
            Mobile = mobile;
        }
    }
}
