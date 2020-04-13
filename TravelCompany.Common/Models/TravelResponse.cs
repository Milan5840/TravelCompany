using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TravelCompany.Common.Models
{
    public class TravelResponse
    {
        public int id { get; set; }

        public int Document { get; set; }

        public String FullName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartDateLocal => StartDate.ToLocalTime();

        public DateTime? EndDate { get; set; }

        public DateTime? EndDateLocal => EndDate?.ToLocalTime();

        public String City { get; set; }

        public String VisitReason { get; set; }

        //public List<ExpensesResponse> Expenses { get; set; }
    }
}
