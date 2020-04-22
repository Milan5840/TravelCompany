using System;
using System.Collections.Generic;
using System.Text;
using TravelCompany.Common.Enums;

namespace TravelCompany.Common.Models
{
    public class UserResponse
    {
        public string Document { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public Types Types { get; set; }
    }
}
