using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsinilitiesImplementation
{
    internal abstract class RoleHandler
    {
        private RoleHandler? nextRoleHandler;

        private UserRole necessaryRole;

        protected RoleHandler(UserRole necesseryRole)
        {
            this.necessaryRole = necesseryRole;
            this.nextRoleHandler = null;
        }

        protected RoleHandler(RoleHandler nextRoleHandler, UserRole necesseryRole)
        {
            this.nextRoleHandler = nextRoleHandler;
            this.necessaryRole = necesseryRole;
        }

        public void Handle(UserRole userRole)
        {
            if (this.necessaryRole <= userRole)
            {
                GiveRoots(userRole);

                if (this.nextRoleHandler != null)
                {
                    this.nextRoleHandler.Handle(userRole);
                }
            }
        }

        protected abstract void GiveRoots(UserRole userRole);
    }
}
