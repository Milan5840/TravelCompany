﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data.Entities;

namespace TravelCompany.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TravelEntity> TravelDetails { get; set; }

        public DbSet<ExpensesTypeEntity> ExpensesType { get; set; }

        public DbSet<ExpensesEntity> Expenses { get; set; }
        public DbSet<TravelEntity> Travel { get; set; }

    }
}
