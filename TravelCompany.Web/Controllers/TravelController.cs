using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelCompany.Web.Data;
using TravelCompany.Web.Data.Entities;
using TravelCompany.Web.Helpers;
using TravelCompany.Web.Models;

namespace TravelCompany.Web.Controllers
{
    public class TravelController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserImage _userImage;
        private readonly IConverterHelper _converterHelper;

        public TravelController(DataContext context,
                                IUserImage userImage,
                                IConverterHelper converterHelper)
        {
            _context = context;
            _userImage = userImage;
            _converterHelper = converterHelper;

        }

        // GET: Travel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travel.Include(t => t.Expense).
                ToListAsync());
        }

        // GET: Travel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelEntity = await _context.Travel
                .Include(t => t.Expense)
                .ThenInclude(t => t.Expense)
                .FirstOrDefaultAsync(m => m.id == id);

            if (travelEntity == null)
            {
                return NotFound();
            }

            return View(travelEntity);
        }

        // GET: Travel/Create
        public async Task<IActionResult> Create(TravelEntity travelEntity)
        {
            if (ModelState.IsValid) {

                _context.Add(travelEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex) {

                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }

            return View(travelEntity); 
        }

        // POST: Travel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*public async Task<IActionResult> Create([Bind("id,Document,FullName,StartDate,EndDate,City,VisitReason")] TravelEntity travelEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelEntity);
        }*/

        // GET: Travel/Edit/5
        public async Task<IActionResult> Edit(int? id, TravelEntity travelEntity)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid) {

                _context.Update(travelEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex) {

                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
            return View(travelEntity);
        }

        // POST: Travel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Document,FullName,StartDate,EndDate,City,VisitReason")] TravelEntity travelEntity)
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

            TravelEntity travelEntity = await _context.Travel
                .FirstOrDefaultAsync(m => m.id == id);
            if (travelEntity == null)
            {
                return NotFound();
            }

            _context.Travel.Remove(travelEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // POST: Travel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelEntity = await _context.Travel.FindAsync(id);
            _context.Travel.Remove(travelEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelEntityExists(int id)
        {
            return _context.Travel.Any(e => e.id == id);
        }

        public async Task<IActionResult> AddExpense(int? id) {

            if (id == null) {

                return NotFound();
            }

            var travelEntity = await _context.Travel.FindAsync(id);
            if (travelEntity == null)
            {
                return NotFound();
            }

            var model = new ExpensesViewModel
            {
                Travel = travelEntity,
                Travelid = travelEntity.id
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddExpense(ExpensesViewModel model)
        {
            if (ModelState.IsValid)
            {
                var path = string.Empty;

                if (model.Photo != null)
                {
                    path = await _userImage.UploadImageAsync(model.PhotoFile, "Drawable");
                }

                var expenseEntity = await _converterHelper.ToExpenseEntity(model, path, true);

                _context.Add(expenseEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction($"{nameof(Details)}/{model.Travelid}");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }

            }

            return View(model);
        }
        public async Task<IActionResult> DeleteExpense(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseEntity = await _context.Expenses
                .Include(g => g.Travel)
                .FirstOrDefaultAsync(m => m.id == id);
            if (expenseEntity == null)
            {
                return NotFound();
            }

            _context.Expenses.Remove(expenseEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction($"{nameof(Details)}/{expenseEntity.Travel.id}");
        }
    }
}
