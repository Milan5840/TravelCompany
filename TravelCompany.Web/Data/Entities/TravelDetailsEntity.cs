using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class TravelDetailsEntity
    {
        public int id { get; set; }
        public int Document { get; set; }

        public String FullName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        public DateTime DateLocal => Date.ToLocalTime();

        public String City { get; set; }

        public ICollection<TravelEntity> Travel { get; set; }


    }
}
