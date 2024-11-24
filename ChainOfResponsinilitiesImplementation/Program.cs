using System;
using System.Collections.Generic;

namespace ChainOfResponsinilitiesImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoleHandler roleHandler = new UnautorizedRoleHandler(
                new AutorizedRoleHandler(
                    new AdminRoleHandler(UserRole.ADMIN), UserRole.AUTORIZED
                    ), UserRole.UNAUTORIZED
                );

            roleHandler.Handle(UserRole.ADMIN);
        }
    }
}