using Microsoft.AspNetCore.Mvc;
using TMS.Repositories.Interface;
using TMS.Models.Domain;
using TMS.Models.DTO.Department;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment department;
        public DepartmentController(IDepartment _department)
        {
            this.department = _department;
        }

        [HttpPost("add")]
        public async Task<ActionResult<DepartmentResponse>> CreateDepartment(CreateDepartmentRequest request)
        {
            var dept = new Department()
            {
                Name = request.Name
            };
            await department.CreateDepartment(dept);
            var res = new DepartmentResponse()
            {
                Id = dept.Id,
                Name = dept.Name,
                CreatedAt = dept.CreatedAt
            };
            return Ok(res);
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<DepartmentResponse>>> GetAllDepartment()
        {
            List<Department> res = await department.GetAllDepartment();

            List<DepartmentResponse> new_res = res.Select(x => new DepartmentResponse()
            {
                Id = x.Id,
                Name = x.Name,
                CreatedAt = x.CreatedAt
            }).ToList();

            return Ok(new_res);

        }
        [HttpDelete("del")]
        public async Task<ActionResult<bool>> DeleteDepartment(Guid id)
        {
            if(id == null)
            {
                return BadRequest(false);
            }
            await department.DeleteDepartment(id);
            return Ok(true);
        }
        [HttpGet("get")]
        public async Task<ActionResult<DepartmentResponse>> GetDepartment(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var res = await department.GetDepartmentById(id);
            if(res == null)
            {
                return NotFound();
            }
            DepartmentResponse dept = new DepartmentResponse()
            {
                Id = res.Id,
                Name = res.Name,
                CreatedAt = res.CreatedAt
            };
            return Ok(dept);
        }

        [HttpPut]
        [Route("{id:Guid}/update")]
        public async  Task<ActionResult> UpdateDepartment([FromRoute] Guid id, [FromBody] CreateDepartmentRequest request)
        {
            Department dpt = new Department()
            {
                Id = id,
                Name = request.Name
            };

            var res = await department.UpdateAsync(dpt);
            if (res == null) return NotFound();
            return Ok();
        }
    }
}
