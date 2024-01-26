using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMS.Models.Domain;
using TMS.Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    public class SubjectController : Controller
    {
        private readonly ISubjectRepository subjectRepository;
        public SubjectController(ISubjectRepository subject)
        {
            subjectRepository = subject;
        }
        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<List<Subject>>> GetAllSubjects()
        {
            return await subjectRepository.GetAllAysn();
        }
    }
}

