using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class MembershipService
    {
        private readonly MembershipRepository membershipRepository = new MembershipRepository();

        public List<MembershipType> GetMembershipType()
        {
            return membershipRepository.GetMembershipType();
        }
    }
}
