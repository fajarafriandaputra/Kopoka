using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrialDev.Data;
using TrialDev.Models;
using TrialDev.Services;

namespace TrialDev.Controllers
{
    public class JobVacanciesController : Controller
    {
        private readonly IJobVacancy _IjobVacancy;

        public JobVacanciesController(IJobVacancy IjobVacancy)
        {
            _IjobVacancy = IjobVacancy;
        }

        // GET: JobVacancies
        public IActionResult Index()
        {
            return View();
        }

        // GET: JobVacancies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobVacancy = await _IjobVacancy.getById(id);
            if (jobVacancy == null)
            {
                return NotFound();
            }

            return View(jobVacancy);
        }

        // GET: JobVacancies/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobVacancyDTO jobVacancyDTO)
        {
            if (ModelState.IsValid)
            {
                await _IjobVacancy.Insert(jobVacancyDTO);
                await _IjobVacancy.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(jobVacancyDTO);
        }

        // GET: JobVacancies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobVacancy = await _IjobVacancy.getById(id);
            if (jobVacancy == null)
            {
                return NotFound();
            }
            return View(jobVacancy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(JobVacancyDTO jobVacancyDTO)
        {
            if (ModelState.IsValid)
            {
                await _IjobVacancy.Update(jobVacancyDTO);
                await _IjobVacancy.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(jobVacancyDTO);
        }

        // GET: JobVacancies/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            await _IjobVacancy.Delete(id);
            await _IjobVacancy.Save();
            return RedirectToAction(nameof(Index));
        }

        // POST: JobVacancies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (id != null && id > 0)
        //    {
        //        await _IjobVacancy.Delete(id);
        //        await _IjobVacancy.Save();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }

        //}

        //private bool JobVacancyExists(int id)
        //{
        //    return _context.JobVacancies.Any(e => e.JobId == id);
        //}
    }
}
