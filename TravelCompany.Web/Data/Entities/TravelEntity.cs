using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Data.Entities
{
    public class TravelEntity
    {
        public int id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(100, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Document { get; set; }

        [Display(Name = "Full Name")]
        [MaxLength(100, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public String FullName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }

        public DateTime StartDateLocal => StartDate.ToLocalTime();
        
        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? EndDate { get; set; }

        public DateTime? EndDateLocal => EndDate?.ToLocalTime();

        [Display(Name = "City")]
        [MaxLength(100, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public String City { get; set; }

        [Display(Name = "Visit Reason")]
        [MaxLength(100, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public String VisitReason { get; set; }

        public ICollection<ExpensesEntity> Expense { get; set; }

        //public UserEntity User { get; set; }

    }
}
