using System.Collections.Generic;
using System.Threading.Tasks;
using TrialDev.Models;

namespace TrialDev.Services
{
    public interface IJobVacancy
    {
        Task<IEnumerable<JobVacancy>> GetJobVacancies();
        Task Save();
        Task Insert(JobVacancy jobVacancy);
        Task Delete(int id);
        Task Update(JobVacancy jobVacancy);
        Task<JobVacancy> getById(int? id);
    }
}
