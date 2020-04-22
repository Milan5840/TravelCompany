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
        Task<ExpensesEntity> ToExpenseEntity(ExpensesViewModel model, string path, bool isNew);

        ExpensesViewModel ToExpensesViewModel(ExpensesViewModel model, ExpensesEntity expensesEntity);
        object ToExpenseEntity(TravelEntity travelEntity);
        object ToTravelResponse(TravelEntity travelEntity);
        object ToExpensesViewModel(ExpensesEntity expenseEntity);
        //object ToExpensesViewModel(ExpensesEntity expenseEntity);


    }
}

    



  

    