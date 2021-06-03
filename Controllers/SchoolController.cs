using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Data;
using SchoolAPI.DTOs;
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
        private readonly IMapper _mapper;

        public SchoolController(ISchoolRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all Person
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseReadDTO>>> GetAllCoursesFromDb()
        {
            var result = await _repo.GetAllCourses();
            return Ok(_mapper.Map<IEnumerable<CourseReadDTO>>(result));
        }

        /// <summary>
        /// Get a specific Person.
        /// </summary>
        /// <remarks>
        /// Description
        ///
        ///     Get /api/Person/{id}
        ///     This will return you the JSON Object
        ///
        /// </remarks>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<CourseReadDTO> GetCourseByIdFromDb(int id)
        {
            var result = _repo.GetCourseById(id);
            if (result != null)
                return Ok(_mapper.Map<CourseReadDTO>(result));
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
