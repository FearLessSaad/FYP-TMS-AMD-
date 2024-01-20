using TMS.Models.Domain;

namespace TMS.Repositories.Interface
{
    public interface IDepartment
    {
        public Task<Department> CreateDepartment(Department dept);
        public Task<List<Department>> GetAllDepartment();
        public Task<bool> DeleteDepartment(Guid id);
        public Task<Department> GetDepartmentById(Guid id);
    }
}
