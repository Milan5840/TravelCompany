using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account.Manage;
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

        public SeedDb(DataContext dataContext) {

            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckTravelsAsync();
        }

        public async Task CheckTravelsAsync() 
        {
            if (!_dataContext.Travel.Any()) 
            {
                _dataContext.Travel.Add(new TravelEntity
                {
                    StartDate = "2019/12/04",
                    EndDate = "2019/12/28",
                    Total = 23454
                },
                new TravelEntity
                {
                    StartDate = "2020/03/14",
                    EndDate = "2020/03/28",
                    Total = 456000
                });

                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
