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
    public class ExpensesTypeController : Controller
    {
        private readonly DataContext _context;

        public ExpensesTypeController(DataContext context)
        {
            _context = context;
        }

        // GET: ExpensesType
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpensesType.ToListAsync());
        }

        // GET: ExpensesType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesTypeEntity = await _context.ExpensesType
                .FirstOrDefaultAsync(m => m.id == id);
            if (expensesTypeEntity == null)
            {
                return NotFound();
            }

            return View(expensesTypeEntity);
        }

        // GET: ExpensesType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpensesType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name")] ExpensesTypeEntity expensesTypeEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expensesTypeEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expensesTypeEntity);
        }

        // GET: ExpensesType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesTypeEntity = await _context.ExpensesType.FindAsync(id);
            if (expensesTypeEntity == null)
            {
                return NotFound();
            }
            return View(expensesTypeEntity);
        }

        // POST: ExpensesType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name")] ExpensesTypeEntity expensesTypeEntity)
        {
            if (id != expensesTypeEntity.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expensesTypeEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpensesTypeEntityExists(expensesTypeEntity.id))
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
            return View(expensesTypeEntity);
        }

        // GET: ExpensesType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesTypeEntity = await _context.ExpensesType
                .FirstOrDefaultAsync(m => m.id == id);
            if (expensesTypeEntity == null)
            {
                return NotFound();
            }

            return View(expensesTypeEntity);
        }

        // POST: ExpensesType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expensesTypeEntity = await _context.ExpensesType.FindAsync(id);
            _context.ExpensesType.Remove(expensesTypeEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpensesTypeEntityExists(int id)
        {
            return _context.ExpensesType.Any(e => e.id == id);
        }
    }
}