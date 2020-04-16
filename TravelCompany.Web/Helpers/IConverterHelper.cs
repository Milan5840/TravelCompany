using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Common.Models;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Helpers
{
    public interface IConverterHelper
    {
        ExpensesEntity ToExpenseEntity(ExpensesViewModel model, string path, bool isNew);

        ExpensesViewModel ToExpensesViewModel(ExpensesEntity expensesEntity);
    }
}

    