using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMS.Models.Domain;
using TMS.Models.DTO.Faculty;
using TMS.Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    public class FacultyController : Controller
    {
        private readonly IFacultyRepository facultyRepo;
        private readonly IDepartment departentRepo;
        public FacultyController(IFacultyRepository faculty, IDepartment dpt)
        {
            facultyRepo = faculty;
            departentRepo = dpt;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<List<Faculty>>> GetAllFaculties()
        {
            return await facultyRepo.GetAllAsync();
        }

        [HttpPost]
        [Route("{id:Guid}/add")]
        public async Task<ActionResult> CreateFaculty([FromRoute] Guid id, [FromBody] CreateFacultyRequest request)
        {
            Faculty faculty = new Faculty()
            {
                FullName = request.FullName,
                CNIC = request.CNIC,
                Address = request.Address,
                Gender = request.Gender,
                Salary = request.Salary
            };

            var dept = await departentRepo.GetDepartmentById(id);

            if (dept == null) return NotFound();
            faculty.Department = dept;

            await facultyRepo.CreateAsync(faculty);

            return Ok();
        }

    }
}

