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

        [MaxLength(50, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public String Name { get; set; }
        public ICollection<ExpensesTypeEntity> ExpensesType { get; set; }
    }
}
