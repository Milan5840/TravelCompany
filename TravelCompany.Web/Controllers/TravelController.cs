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
    public class TravelController : Controller
    {
        private readonly DataContext _context;

        public TravelController(DataContext context)
        {
            _context = context;
        }

        // GET: Travel
        public async Task<IActionResult> Index()
        {
            return View(await _context.TravelDetails.ToListAsync());
        }

        // GET: Travel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelEntity = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.id == id);
            if (travelEntity == null)
            {
                return NotFound();
            }

            return View(travelEntity);
        }

        // GET: Travel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Travel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Document,FullName,StartDate,EndDate,City,VisitReason,ExpenseTotal")] TravelEntity travelEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelEntity);
        }

        // GET: Travel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelEntity = await _context.TravelDetails.FindAsync(id);
            if (travelEntity == null)
            {
                return NotFound();
            }
            return View(travelEntity);
        }

        // POST: Travel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Document,FullName,StartDate,EndDate,City,VisitReason,ExpenseTotal")] TravelEntity travelEntity)
        {
            if (id != travelEntity.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelEntityExists(travelEntity.id))
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
            return View(travelEntity);
        }

        // GET: Travel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelEntity = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.id == id);
            if (travelEntity == null)
            {
                return NotFound();
            }

            return View(travelEntity);
        }

        // POST: Travel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelEntity = await _context.TravelDetails.FindAsync(id);
            _context.TravelDetails.Remove(travelEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelEntityExists(int id)
        {
            return _context.TravelDetails.Any(e => e.id == id);
        }
    }
}