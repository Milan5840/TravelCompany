using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelCompany.Web.Data;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Helpers;

namespace TravelCompany.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConverterHelper _converterHelper;

        public TravelsController(DataContext context,
                                 IConverterHelper converterHelper)
        {
            _context = context;
            _converterHelper = converterHelper;
        }


        [HttpGet("{Document}")]
        public async Task<IActionResult> GetTravelEntity([FromRoute] int Document)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TravelEntity travelEntity = await _context.Travel
                .Include(t => t.Expense)
                .Include(t => t.City)
                .Include(t => t.User)
                .FirstOrDefault(t => t.Document = Document);


            if (travelEntity == null)
            {
                return NotFound();
            }

            return Ok(_converterHelper.ToTravelResponse(travelEntity));
        }
    }
}