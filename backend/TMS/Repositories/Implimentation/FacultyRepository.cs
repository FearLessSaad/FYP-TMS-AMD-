using TMS.Data;
using TMS.Models.Domain;
using TMS.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace TMS.Repositories.Implimentation
{ 
    public class FacultyRepository : IFacultyRepository
    {
        private readonly TmsDatabaseContext databaseContext;
        public FacultyRepository(TmsDatabaseContext context)
        {
            databaseContext = context;
        }

        public async Task<Faculty> CreateAsync(Faculty faculty)
        {
            await databaseContext.Faculties.AddAsync(faculty);
            await databaseContext.SaveChangesAsync();
            return faculty;
        }

        public async Task<List<Faculty>> GetAllAsync()
        {
            return await databaseContext.Faculties.Include(x => x.Department).ToListAsync();
        }
    }
}

