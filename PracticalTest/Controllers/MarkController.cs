using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;
using PracticalTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class MarkController : Controller
    {
        private readonly IMarkService markService;

        public MarkController(IMarkService markService)
        {
            this.markService = markService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMarks()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> SaveMarks([FromBody]Mark article)
        //{


        //    return new JsonResult("");
        //}

        [HttpPost]
        public async Task<IActionResult> SaveMarks([FromBody] Mark mark)
        {
            var model = new Domain.Models.Mark
            {
                Marks = mark.Marks,
                TeacherSubjectId = mark.TeacherSubjectId,
                StudentId = mark.StudentId,
                TeacherSubject = new Domain.Models.TeacherSubject
                {
                    TeacherId = mark.TeacherId,
                    SubjectId = mark.SubjectId,
                }
            };

            var res = await markService.Add(model);

            return new JsonResult("");
        }

        [HttpGet]
        public async Task<IActionResult> GetMarks()
        {
            var res = await markService.GetAll();

            return new JsonResult(res);
        }

    }
}


//public class Article
//{
//    public int GradeId { get; set; }
//    public int StudentId { get; set; }
//    public int SubjectId { get; set; }
//    public int TeacherId { get; set; }
//    public int Marks { get; set; }
//    public int TeacherSubjectId { get; set; }
//}