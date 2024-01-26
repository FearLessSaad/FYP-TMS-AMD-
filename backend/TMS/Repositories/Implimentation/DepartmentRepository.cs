using TMS.Models.Domain;
using TMS.Repositories.Interface;
using TMS.Data;
using Microsoft.EntityFrameworkCore;

namespace TMS.Repositories.Implimentation
{
    public class DepartmentRepository : IDepartment
    {

        private readonly TmsDatabaseContext dbContext;

        public DepartmentRepository(TmsDatabaseContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public async Task<Department> CreateDepartment(Department dept)
        {
            await dbContext.Departments.AddAsync(dept);
            await dbContext.SaveChangesAsync();
            return dept;
        }

        public async Task<bool> DeleteDepartment(Guid id)
        {
            var temp = await dbContext.Departments.FirstOrDefaultAsync(x => x.Id == id);
            dbContext.Departments.Attach(temp);
            dbContext.Departments.Remove(temp);
            var result = await dbContext.SaveChangesAsync();
            Console.WriteLine(result);
            return true;
        }

        public async Task<List<Department>> GetAllDepartment()
        {
            return await dbContext.Departments.ToListAsync();
        }

        public async Task<Department?> GetDepartmentById(Guid id)
        {
            return await dbContext.Departments.FirstOrDefaultAsync(x => x.Id ==id);
        }

        public async Task<Department?> UpdateAsync(Department dept)
        {
            var tmp = await dbContext.Departments.FirstOrDefaultAsync(x => x.Id == dept.Id);
            
            if(tmp != null)
            {
                dbContext.Departments.Attach(tmp).CurrentValues.SetValues(dept);
                await dbContext.SaveChangesAsync();
                return dept;
            }
            return null;
        }
    }
}
