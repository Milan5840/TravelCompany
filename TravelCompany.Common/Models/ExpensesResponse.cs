using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCompany.Common.Models
{
    class ExpensesResponse
    {
        public int id { get; set; }

        public double feeding { get; set; }

        public double lodging { get; set; }

        public double transport { get; set; }

        public double representation { get; set; }

        public string Photo { get; set; }

        public double ExpenseTotal { get; set; }

        public TravelResponse Travel { get; set; }
    }
}
