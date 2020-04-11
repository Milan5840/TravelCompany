using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class ExpensesTypeEntity
    {
        public String VisitReason { get; set; }

        public int NumberDays { get; set; }

        public ICollection<ExpensesEntity> Expenses { get; set; }
    }
}
