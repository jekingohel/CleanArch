using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArche.Application.Interfaces;
using CleanArche.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CourseViewModel model)
        {
            _courseService.Add(model);
            return Ok("");
        }

    }
}
