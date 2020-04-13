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

        private async Task CheckExpensesAsync()
        {
            if (!_dataContext.Expenses.Any()) {

                _dataContext.Expenses.Add(new ExpensesEntity
                {
                    feeding = 1232,
                    lodging = 345484,
                    transport = 458900,
                    representation = 456000
                }
                    );
                _dataContext.Expenses.Add(new ExpensesEntity
                {
                    feeding = 1232,
                    lodging = 345484,
                    transport = 458900,
                    representation = 456000
                }
                    );

                await _dataContext.SaveChangesAsync();
            }
        }
    }
}

