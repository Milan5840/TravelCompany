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


namespace TravelCompany.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public ExpensesEntity ToExpenseEntity(ExpensesViewModel model, string path, bool isNew)
        {
            return new ExpensesEntity
            {
                id = isNew ? 0 : model.id,
                feeding = model.feeding,
                lodging = model.lodging,
                transport = model.transport,
                representation = model.representation,
                Photo = path,
                ExpenseTotal = model.ExpenseTotal

            };
        }

        public ExpensesViewModel ToExpensesViewModel(ExpensesEntity expensesEntity)
        {
            return new ExpensesViewModel
            {
                id = expensesEntity.id,
                feeding = expensesEntity.feeding,
                lodging = expensesEntity.lodging,
                transport = expensesEntity.transport,
                representation = expensesEntity.representation,
                Photo = expensesEntity.Photo,
                ExpenseTotal = expensesEntity.ExpenseTotal
            };
        }

    }
 }
    
    


