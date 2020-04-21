using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.Internal;
using TravelCompany.Web.Migrations;
using Microsoft.CodeAnalysis;
using TravelCompany.Common.Models;
using TravelCompany.Web.Models;
using TravelCompany.Web.Data;

namespace TravelCompany.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {

        private readonly DataContext _dataContext;

        public ConverterHelper(DataContext DataContext)
        {
            _dataContext = DataContext;
        }

        public ExpensesViewModel ToExpensesViewModel(ExpensesEntity expensesEntity)
        {
            return new ExpensesViewModel
            {
                id = expensesEntity.id,
                Expense = expensesEntity.Expense,
                ExpenseTotal = expensesEntity.ExpenseTotal,
                Date = expensesEntity.Date.ToUniversalTime(),
                Photo = expensesEntity.Photo,
                Travelid = expensesEntity.Travel.id
            };
        }
        public async Task<ExpensesEntity> ToExpenseEntity(ExpensesViewModel model, string path, bool isNew)
        {
            return new ExpensesEntity
            {
                id = isNew ? 0 : model.id,
                Expense = model.Expense,
                ExpenseTotal = model.ExpenseTotal,
                Date = model.Date.ToUniversalTime(),
                Photo = path,
                Travel = await _dataContext.Travel.FindAsync(model.Travelid)

            };
        }
    }
}
    
    


