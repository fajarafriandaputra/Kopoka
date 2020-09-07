using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialDev.Data;
using TrialDev.Models;

namespace TrialDev.Services
{
    public class JobVacancyRepository : IJobVacancy
    {

        private readonly ApplicationDbContext _context;
        public JobVacancyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            JobVacancy jv = await getById(id);
            _context.Remove(jv);
        }

        public async Task<JobVacancy> getById(int? id)
        {
            return _context.JobVacancies.Where(a => a.JobId.Equals(id)).SingleOrDefault();
        }

        public async Task<IEnumerable<JobVacancy>> GetJobVacancies()
        {
            return _context.JobVacancies.ToList();
        }

        public async Task Insert(JobVacancy jobVacancy)
        {
            _context.Add(jobVacancy);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(JobVacancy jobVacancy)
        {
            _context.JobVacancies.Update(jobVacancy);
        }

        
    }
}
