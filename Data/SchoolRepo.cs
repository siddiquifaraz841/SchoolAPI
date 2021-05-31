using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Data
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly SchoolContext _context;

        public SchoolRepo(SchoolContext context)
        {
            _context = context;
        }

        public void AddCourse(Course obj)
        {
            _context.Courses.Add(obj);
        }

        public void DeleteCourseById(Course obj)
        {
            _context.Courses.Remove(obj);
        }

        public async Task<IEnumerable<Course>> GetAllCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.FirstOrDefault(x => x.CourseId == courseId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
