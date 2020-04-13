using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class ExpensesEntity
    {
        public int id { get; set; }

        public double feeding { get; set; }

        public double lodging { get; set; }

        public double transport { get; set; }

        public double representation { get; set; }

        public string Photo { get; set; }

        public double ExpenseTotal { get; set; }

        public TravelEntity Travel { get; set; }

    }
}
