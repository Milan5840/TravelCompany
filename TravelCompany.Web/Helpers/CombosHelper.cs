using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        public IEnumerable<SelectListItem> GetComboExpenses()
        {
            List<SelectListItem> list = new List<SelectListItem> 
            {
                new SelectListItem { Text = "[Select a Expense Type...]" },
                new SelectListItem { Text = "Feeding" },
                new SelectListItem { Text = "Lodging" },
                new SelectListItem { Text = "Transport" },
                new SelectListItem { Text = "Representation" },
            };

            return list;
        }
    }
}
