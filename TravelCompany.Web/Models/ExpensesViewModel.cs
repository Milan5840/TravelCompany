using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Models
{
    public class ExpensesViewModel
    {
        [Display(Name = "Photo")]
        public IFormFile Photo { get; set; }
    }
}
