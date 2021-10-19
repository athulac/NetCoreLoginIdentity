using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Domain.Models;
using PracticalTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class SubjectController : Controller
    {
        private readonly ISubjectService subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await subjectService.GetAll();

            return new JsonResult(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetTeachBySubjectId(int subjectId)
        {
            var res = await subjectService.GetTeachBySubjectId(subjectId);

            return new JsonResult(res);
        }
    }
}
