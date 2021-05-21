using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Data
{
    public interface ISchoolRepo
    {
        IEnumerable<Course> GetAllCourses();

        Course GetCourseById(int courseId);

        void DeleteCourseById(Course obj);

        bool SaveChanges();

        void AddCourse(Course obj);
    }
}
