﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelCompany.Web.Data;
using TravelCompany.Web.Data.Entities;

namespace TravelCompany.Web.Controllers
{
    public class TravelDetailsController : Controller
    {
        private readonly DataContext _context;

        public TravelDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: TravelDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.TravelDetails.ToListAsync());
        }

        // GET: TravelDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetailsEntity = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.id == id);
            if (travelDetailsEntity == null)
            {
                return NotFound();
            }

            return View(travelDetailsEntity);
        }

        // GET: TravelDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Document,FullName,Date,City")] TravelDetailsEntity travelDetailsEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelDetailsEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelDetailsEntity);
        }

        // GET: TravelDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetailsEntity = await _context.TravelDetails.FindAsync(id);
            if (travelDetailsEntity == null)
            {
                return NotFound();
            }
            return View(travelDetailsEntity);
        }

        // POST: TravelDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Document,FullName,Date,City")] TravelDetailsEntity travelDetailsEntity)
        {
            if (id != travelDetailsEntity.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelDetailsEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelDetailsEntityExists(travelDetailsEntity.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(travelDetailsEntity);
        }

        // GET: TravelDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetailsEntity = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.id == id);
            if (travelDetailsEntity == null)
            {
                return NotFound();
            }

            return View(travelDetailsEntity);
        }

        // POST: TravelDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelDetailsEntity = await _context.TravelDetails.FindAsync(id);
            _context.TravelDetails.Remove(travelDetailsEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelDetailsEntityExists(int id)
        {
            return _context.TravelDetails.Any(e => e.id == id);
        }
    }
}