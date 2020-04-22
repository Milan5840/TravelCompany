using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCompany.Common.Models
{
    public class ExpensesTypeResponse
    {
        public int Id { get; set; }

        public String name { get; set; } 

        public List<ExpensesResponse> Expenses { get; set; }

        public UserResponse User { get; set; }

    }
}
