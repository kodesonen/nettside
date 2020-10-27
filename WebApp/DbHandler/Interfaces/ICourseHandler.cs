using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;

namespace WebApp.DbHandler.Interfaces
{
    public interface ICourseHandler
    {
        public List<Course> LoadAll();
    }

    public class CourseHandler : ICourseHandler
    {
        private readonly DataContext db;
        public CourseHandler(DataContext _db)
        {
            this.db = _db;
        }

        public List<Course> LoadAll()
        {
            var Data = db.Courses;
            List<Course> ListOfCourses = Data.ToList();
            return ListOfCourses;
        }
    }
}
