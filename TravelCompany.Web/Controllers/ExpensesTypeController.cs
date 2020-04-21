using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelCompany.Web.Data;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Helpers;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Controllers
{
    public class ExpensesTypeController : Controller
    {
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;

        public ExpensesTypeController(DataContext context,
                                      ICombosHelper combosHelper)
        {
            _context = context;
            _combosHelper = combosHelper;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpensesTypeEntity expensesTypeEntity)
        {
            if (ModelState.IsValid)
            {
                ExpensesViewModel model = new ExpensesViewModel
                {
                    ExpenseTypeId = _combosHelper.GetComboExpenses()
                };
                _context.Add(expensesTypeEntity);

                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex) {

                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, $"Already exists a Expense Type {expensesTypeEntity.Name}.");
                        //ExpenseTypeId = _combosHelper.GetComboExpenses();
                        //return View(ExpensesViewModel);

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
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

            ExpensesTypeEntity expensesTypeEntity = await _context.ExpensesType.FindAsync(id);
            if (expensesTypeEntity == null)
            {
                return NotFound();
            }
            return View(expensesTypeEntity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ExpensesTypeEntity expensesTypeEntity)
        {
            if (id != expensesTypeEntity.id)
            {
                ExpensesViewModel model = new ExpensesViewModel
                {
                    ExpenseTypeId = _combosHelper.GetComboExpenses()
                };
                return View(model);
            }

            if (ModelState.IsValid)
            {
                _context.Update(expensesTypeEntity);

                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, $"Already exists a expense type {expensesTypeEntity.Name}.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
            }
            return View(expensesTypeEntity);
        }

        // GET: ExpensesType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                ExpensesViewModel model = new ExpensesViewModel
                {
                    ExpenseTypeId = _combosHelper.GetComboExpenses()
                };
                return View(model);
            }

            var expensesTypeEntity = await _context.ExpensesType
                .FirstOrDefaultAsync(m => m.id == id);
            if (expensesTypeEntity == null)
            {
                return NotFound();
            }

            _context.ExpensesType.Remove(expensesTypeEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
