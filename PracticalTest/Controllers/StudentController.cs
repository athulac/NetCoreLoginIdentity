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
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetByGrade(int gradeId)
        {
            var grade = new Grade
            {
                Id = gradeId
            };
            var res = await studentService.GetByGrade(grade);

            return new JsonResult(res);
        }
    }
}
