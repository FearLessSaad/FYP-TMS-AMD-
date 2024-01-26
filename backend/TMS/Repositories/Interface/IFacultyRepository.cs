using TMS.Models.Domain;
namespace TMS.Repositories.Interface
{
	public interface IFacultyRepository
	{
		Task<List<Faculty>> GetAllAsync();
		Task<Faculty> CreateAsync(Faculty faculty);

	}
}

