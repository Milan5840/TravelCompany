using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.Internal;
using TravelCompany.Web.Migrations;
using Microsoft.CodeAnalysis;

namespace TravelCompany.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        /*public TravelResponse ToExpensesResponse(TravelEntity travelEntity)
        { 
           return new TravelResponse
           {
               id = travelEntity.id,
               Document = travelEntity.Document,
               FullName = travelEntity.FullName,
               StartDate = travelEntity.StartDate,
               EndDate = travelEntity.EndDate,
               City = travelEntity.City,
               VisitReason = travelEntity.VisitReason,
               Expenses = travelEntity.Expense?.Select(t => new ExpensesResponse
               {  
               id = t.id,
               feeding = t.feeding,
               lodging = t.lodging,
               transport = t.transport,
               representation = t.representation,
               Photo = t.Photo,
               ExpenseTotal = t.ExpenseTotal,



           }
        
        }*/
    
    }

}
