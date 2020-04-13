using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class ExpensesTypeEntity
    {
        public int id { get; set; }

        public String Name { get; set; }
        public ICollection<TravelEntity> Travel { get; set; }
    }
}
