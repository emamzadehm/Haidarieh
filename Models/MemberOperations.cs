using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore.Models
{
    public class MemberOperations
    {
        private readonly EfContext _efContext;

        public MemberOperations(EfContext efContext)
        {
            _efContext = efContext;
        }

        public List<Member> GetAll()
        {
            return _efContext.Members.ToList();
        }
    }
}
