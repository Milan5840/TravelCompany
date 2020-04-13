using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Common.Models;

namespace TravelCompany.Web.Helpers
{
    public interface IConverterHelper
    {
        ExpensesResponse ToExpensesResponse(ExpensesEntity expensesEntity);
    }
}

    