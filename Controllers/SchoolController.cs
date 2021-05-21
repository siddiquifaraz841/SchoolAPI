using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Data;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    [Route("api/school")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepo _repo;

        public SchoolController(ISchoolRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAllCoursesFromDb()
        {
            var result = _repo.GetAllCourses();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourseByIdFromDb(int id)
        {
            var result = _repo.GetCourseById(id);
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            var result = _repo.GetCourseById(id);
            if(result != null)
            {
                _repo.DeleteCourseById(result);
                _repo.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult AddCourse(Course obj)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _repo.AddCourse(obj);
            _repo.SaveChanges();
            return NoContent();
        }

    }
}
