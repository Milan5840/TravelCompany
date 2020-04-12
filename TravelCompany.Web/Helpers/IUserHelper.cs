using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Helpers
{
    public interface IUserHelper
    {
        Task CheckRoleAsync(string roleName);
    }
}
