using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class GradeController : Controller
    {
        private readonly IGradeService gradeService;

        public GradeController(IGradeService gradeService)
        {
            this.gradeService = gradeService;
        }

        
        public async Task<IActionResult> GetAll()
        {
            var res = await gradeService.GetAll();
            
            return new JsonResult(res);
        }
    }
}
