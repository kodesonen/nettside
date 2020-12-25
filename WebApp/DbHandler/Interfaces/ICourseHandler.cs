using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DbHandler.Models;
using WebApp.Models.Admin;

namespace WebApp.DbHandler.Interfaces
{
    public interface ICourseHandler
    {
        public List<Course> LoadAll();
        public bool AddNewCourse(NewCourseModel model);
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

        public bool AddNewCourse(NewCourseModel model)
        {
            Course newCourse = new Course()
            {
                Name = model.Name,
                Description = model.Description,
                Icon = model.Icon
            };

            db.Courses.Add(newCourse);
            db.SaveChanges();

            /* Burde antakeligvis være noe feilsjekk her */
            return true;
        }
    }
}
