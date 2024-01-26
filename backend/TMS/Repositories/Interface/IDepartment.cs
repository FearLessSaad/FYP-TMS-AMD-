using TMS.Models.Domain;

namespace TMS.Repositories.Interface
{
    public interface IDepartment
    {
        Task<Department> CreateDepartment(Department dept);
        Task<List<Department>> GetAllDepartment();
        Task<bool> DeleteDepartment(Guid id);
        Task<Department?> GetDepartmentById(Guid id);
        Task<Department?> UpdateAsync(Department dept);
    }
}
