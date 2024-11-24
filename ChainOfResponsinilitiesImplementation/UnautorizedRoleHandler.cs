using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsinilitiesImplementation
{
    internal class UnautorizedRoleHandler : RoleHandler
    {
        public UnautorizedRoleHandler(RoleHandler nextRoleHandler, UserRole necesseryRole) : base(nextRoleHandler, necesseryRole)
        {

        }

        protected override void GiveRoots(UserRole userRole)
        {
            Console.WriteLine("User is unautorized! First level of roots...");
        }
    }
}
