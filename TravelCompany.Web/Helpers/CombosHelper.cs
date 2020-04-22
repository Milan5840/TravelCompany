using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TravelCompany.Web.Data;

namespace TravelCompany.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;
        public CombosHelper(DataContext context) 
        {
                
            _context = context;
        }
        public IEnumerable<SelectListItem> GetComboExpenses()
        {
            List<SelectListItem> list = _context.ExpensesType.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = $"{t.id}"
            })
                .OrderBy(t => t.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select a Expense Type...]",
                Value = "0"
            });

            return list;

        }
    }
}
