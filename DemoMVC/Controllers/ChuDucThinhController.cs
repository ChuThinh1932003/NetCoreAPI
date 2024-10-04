using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models.Entities;

namespace DemoMVC.Controllers
{
    public class ChuDucThinhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChuDucThinhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChuDucThinh
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChuDucThinh.ToListAsync());
        }

        // GET: ChuDucThinh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDucThinh = await _context.ChuDucThinh
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (chuDucThinh == null)
            {
                return NotFound();
            }

            return View(chuDucThinh);
        }

        // GET: ChuDucThinh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChuDucThinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Address,MSV")] ChuDucThinh chuDucThinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuDucThinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuDucThinh);
        }

        // GET: ChuDucThinh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDucThinh = await _context.ChuDucThinh.FindAsync(id);
            if (chuDucThinh == null)
            {
                return NotFound();
            }
            return View(chuDucThinh);
        }

        // POST: ChuDucThinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FullName,Address,MSV")] ChuDucThinh chuDucThinh)
        {
            if (id != chuDucThinh.FullName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuDucThinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuDucThinhExists(chuDucThinh.FullName))
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
            return View(chuDucThinh);
        }

        // GET: ChuDucThinh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDucThinh = await _context.ChuDucThinh
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (chuDucThinh == null)
            {
                return NotFound();
            }

            return View(chuDucThinh);
        }

        // POST: ChuDucThinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chuDucThinh = await _context.ChuDucThinh.FindAsync(id);
            if (chuDucThinh != null)
            {
                _context.ChuDucThinh.Remove(chuDucThinh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuDucThinhExists(string id)
        {
            return _context.ChuDucThinh.Any(e => e.FullName == id);
        }
    }
}
