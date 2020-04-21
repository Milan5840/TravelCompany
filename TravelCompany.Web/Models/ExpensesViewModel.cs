using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;

namespace TravelCompany.Web.Models
{
    public class ExpensesViewModel : ExpensesEntity
    {
        [Display(Name = "Photo")]
        public IFormFile PhotoFile { get; set; }

        public int Travelid { get; set; }

        public IEnumerable ExpenseTypeId { get; set; }
    }
}
