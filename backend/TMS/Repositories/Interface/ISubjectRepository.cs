using System;
using TMS.Models.Domain;

namespace TMS.Repositories.Interface
{
	public interface ISubjectRepository
	{
		Task<List<Subject>> GetAllAysn();
	}
}

