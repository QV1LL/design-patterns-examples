using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsinilitiesImplementation
{
    internal class AdminRoleHandler : RoleHandler
    {
        public AdminRoleHandler(UserRole necesseryRole) : base(necesseryRole)
        {

        }

        protected override void GiveRoots(UserRole userRole)
        {
            Console.WriteLine("User is admin! Highest level of roots...");
        }
    }
}
