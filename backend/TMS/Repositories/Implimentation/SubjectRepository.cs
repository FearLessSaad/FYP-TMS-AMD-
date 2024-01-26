using TMS.Data;
using TMS.Models.Domain;
using TMS.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace TMS.Repositories.Implimentation
{
	public class SubjectRepository : ISubjectRepository
	{
        private readonly TmsDatabaseContext dbcontext;
		public SubjectRepository(TmsDatabaseContext _dbcontext)
		{
            dbcontext = _dbcontext;
		}

        public async Task<List<Subject>> GetAllAysn()
        {
            return await dbcontext.Subjects.Include(x => x.Department).ToListAsync();

        }
    }
}

