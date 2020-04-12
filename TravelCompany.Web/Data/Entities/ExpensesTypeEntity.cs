using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class ExpensesTypeEntity
    {
        public int id { get; set; }
        public String VisitReason { get; set; }

        public int NumberDays { get; set; }

        public ICollection<TravelDetailsEntity> TravelDetails { get; set; }
    }
}
