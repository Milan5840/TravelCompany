using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;

namespace TravelCompany.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {

            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckExpensesTypeAsync();
            await CheckTravel();

        }

        private async Task CheckExpensesTypeAsync()
        {
            if (!_dataContext.ExpensesType.Any())
            {

                AddExpenseType("Feeding");
                AddExpenseType("Lodging");
                AddExpenseType("Transport");
                AddExpenseType("Representation");
                AddExpenseType("Other");

                await _dataContext.SaveChangesAsync();
            }
        }

        private void AddExpenseType(string name)
        {

            _dataContext.ExpensesType.Add(new ExpensesTypeEntity { Name = name });
        }

        private async Task CheckTravel()
        {

            var startDate = DateTime.Today.ToUniversalTime();
            var endDate = DateTime.Today.AddMonths(1).ToUniversalTime();

            if (!_dataContext.Travel.Any())
            {
                _dataContext.Travel.Add(new TravelEntity
                {
                    Document = 34908979,
                    FullName = "Isabella Natalia Correa",
                    StartDate = startDate,
                    EndDate = endDate,
                    City = "New York",
                    VisitReason = "Get The Visa",
                    Expense = new List<ExpensesEntity>
                  {
                      new ExpensesEntity
                      {
                          feeding = 342222,
                          lodging = 3432100,
                          transport = 450000,
                          representation = 23029191,
                          Photo = $"~/images/Drawable/Recibo_1.jpg",
                          ExpenseTotal = 27253513

                      }

                  }

                });


                if (!_dataContext.Travel.Any())
                {
                    _dataContext.Travel.Add(new TravelEntity
                    {
                        Document = 657890456,
                        FullName = "Andres Alexis Correa",
                        StartDate = startDate,
                        EndDate = endDate,
                        City = "Los Angeles",
                        VisitReason = "Visit Client Home Center LA",
                        Expense = new List<ExpensesEntity>
                  {
                      new ExpensesEntity
                      {

                          feeding = 600000,
                          lodging = 400000,
                          transport = 2700000,
                          representation = 3450000,
                          Photo = $"~/images/Drawable/agencias-de-viaje-31-638.jpg",
                          ExpenseTotal = 7150000

                      }

                  }

                    });

                    if (!_dataContext.Travel.Any())
                    {
                        _dataContext.Travel.Add(new TravelEntity
                        {
                            Document = 657890456,
                            FullName = "Melissa Taborda Hoyos",
                            StartDate = startDate,
                            EndDate = endDate,
                            City = "Rio De Janeiro",
                            VisitReason = "Vacations",
                            Expense = new List<ExpensesEntity>
                  {
                      new ExpensesEntity
                      {

                          feeding = 4507779,
                          lodging = 2340000,
                          transport = 360000,
                          representation = 2340000,
                          Photo = $"~/images/Drawable/320332_18814.jpg",
                          ExpenseTotal = 9547779

                      }

                  }

                        });

                        if (!_dataContext.Travel.Any())
                        {
                            _dataContext.Travel.Add(new TravelEntity
                            {
                                Document = 78000343,
                                FullName = "Nafer Yosimar Mosquera",
                                StartDate = startDate,
                                EndDate = endDate,
                                City = "Miami",
                                VisitReason = "Visit Call Center Miami",
                                Expense = new List<ExpensesEntity>
                  {
                      new ExpensesEntity
                      {

                          feeding = 560000,
                          lodging = 3400000,
                          transport = 900000,
                          representation = 545000,
                          Photo = $"~/images/Drawable/images.jpg",
                          ExpenseTotal = 5405000

                      }

                  }

                            });

                            if (!_dataContext.Travel.Any())
                            {
                                _dataContext.Travel.Add(new TravelEntity
                                {
                                    Document = 1235766543,
                                    FullName = "Andres Felipe Guerra",
                                    StartDate = startDate,
                                    EndDate = endDate,
                                    City = "Sao Paulo",
                                    VisitReason = "Visit Call Center Sao Paulo",
                                    Expense = new List<ExpensesEntity>
                  {
                      new ExpensesEntity
                      {

                          feeding = 56859484,
                          lodging = 7900000,
                          transport = 345000,
                          representation = 6790000,
                          Photo = $"~/images/Drawable/factura-venta.jpg",
                          ExpenseTotal = 65783484

                      }

                  }

                                });

                                await _dataContext.SaveChangesAsync();

                            }

                        }


                    }


                }
            }
        }
    }
}
    


