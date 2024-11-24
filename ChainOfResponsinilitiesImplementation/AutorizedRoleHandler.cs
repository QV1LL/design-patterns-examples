using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsinilitiesImplementation
{
    internal class AutorizedRoleHandler : RoleHandler
    {
        public AutorizedRoleHandler(RoleHandler nextRoleHandler, UserRole necesseryRole) : base(nextRoleHandler, necesseryRole)
        {

        }

        protected override void GiveRoots(UserRole userRole)
        {
            Console.WriteLine("User is autorized! Second level of roots...");
        }
    }
}
