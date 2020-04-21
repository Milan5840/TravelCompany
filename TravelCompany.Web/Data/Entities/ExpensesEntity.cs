using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{   
    public class ExpensesEntity
    {
        public int id { get; set; }

        [Display(Name = "Expense Type")]
        public ExpensesTypeEntity Expense { get; set; }

        public double ExpenseTotal { get; set; }

        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Expense Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateLocal => Date.ToLocalTime();

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        public TravelEntity Travel { get; set; }

        //public UserEntity User { get; set; }

    }
}
