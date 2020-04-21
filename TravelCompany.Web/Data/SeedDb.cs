using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using TravelCompany.Common.Enums;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Helpers;

namespace TravelCompany.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        //private readonly IUserHelper _userHelper;

        public SeedDb(DataContext dataContext)
                      //IUserHelper userHelper)
        {
            //_userHelper = userHelper;
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckExpensesTypeAsync();
            await CheckTravel();
            //await CheckRoleAsync();
            //await CheckUserAsync();
            //var admin = await CheckUserAsync("345746534", "Juan David Cardozo", "juan@yopmail.com"
                //, "300 900 67 89", "Edificio 89", Types.Admin);
            //var employee = await CheckUserAsync("678934565", "Maria Antonia Morales", "maria@yopmail.com"
                //, "321 450 78 09", "Edificio 89", Types.Employee);


        }

        private async Task CheckRoleAsync()
        {
            //await _userHelper.CheckRoleAsync(Types.Admin.ToString());
            //await _userHelper.CheckRoleAsync(Types.Employee.ToString());
        }

        private Task CheckUserAsync()
        {
            throw new NotImplementedException();
        }
        /*private async Task<UserEntity> CheckUserAsync(
            string document,
            string fullName,
            string email,
            string number,
            string address,
            Types types
            )
        {
            //var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null) {
                user = new UserEntity
                {
                    Document = document,
                    FullName = fullName,
                    Email = email,
                    Number = number,
                    Address = address,
                    Types = types
                    
                };
           
            }

            return user;


        }*/

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
                          Expense = _dataContext.ExpensesType.FirstOrDefault(t => t.Name == "Feeding"),
                          ExpenseTotal = 3460000,
                          Date = startDate.AddDays(5),
                          Photo = $"~/images/Drawable/Recibo_1.png"

                      }

                  }

                }); ;


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

                          Expense = _dataContext.ExpensesType.FirstOrDefault(t => t.Name == "Transport"),
                          ExpenseTotal = 9000000,
                          Date = startDate.AddDays(10),
                          Photo = $"~/images/Drawable/agencias-de-viaje-31-638.jpg"

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

                          Expense = _dataContext.ExpensesType.FirstOrDefault(t => t.Name == "Representation"),
                          ExpenseTotal = 7800000,
                          Date = startDate.AddDays(15),
                          Photo = $"~/images/Drawable/320332_18814.jpg"

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

                          Expense = _dataContext.ExpensesType.FirstOrDefault(t => t.Name == "Feeding"),
                          ExpenseTotal = 6460000,
                          Date = startDate.AddDays(20),
                          Photo = $"~/images/Drawable/images.jpg"

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

                          Expense = _dataContext.ExpensesType.FirstOrDefault(t => t.Name == "Feeding"),
                          ExpenseTotal = 89000000,
                          Date = startDate.AddDays(34),
                          Photo = $"~/images/Drawable/factura-venta.png"

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
    


