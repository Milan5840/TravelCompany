using Microsoft.EntityFrameworkCore.Internal;
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
           
        }

        /*private async Task CheckExpensesAsync()
        {
            if (!_dataContext.Expenses.Any()) {

                _dataContext.Expenses.Add(new ExpensesEntity
                {

                    feeding = 23900,
                    lodging = 124000,
                    transport = 43000,
                    representation = 340900
                },
       
                new ExpensesEntity
                {
                    feeding = 42300,
                    lodging = 89000,
                    transport = 12000,
                    representation = 3900
                });

                await _dataContext.SaveChangesAsync();
            }
        }*/
    }
}

