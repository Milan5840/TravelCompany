using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompany.Web.Data;

namespace TravelCompany.Web.Controllers
{
    public class TravelDetailsController : Controller
    {
        private readonly DataContext _dataContext;
    }
}
