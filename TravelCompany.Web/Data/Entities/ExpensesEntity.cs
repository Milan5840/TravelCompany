using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class ExpensesEntity
    {
        public double feeding { get; set; }

        public double lodging { get; set; }

        public double transport { get; set; }

        public double representation { get; set; }

        public ExpensesTypeEntity ExpensesType { get; set; }

    }
}
