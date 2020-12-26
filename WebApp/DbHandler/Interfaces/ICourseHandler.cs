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
        public List<Module> GetAllModules();
        public List<Module> GetAllModulesById(int courseId);
        public bool AddNewCourse(NewCourseModel model);
        public string GetCourseNameById(int courseId);
        public string GetModuleNameById(int moduleId);
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
            List<Course> allCourses = Data.ToList();
            return allCourses;
        }

        public List<Module> GetAllModules()
        {
            var Data = db.Modules;
            List<Module> allModules = Data.ToList();
            return allModules;
        }

        public List<Module> GetAllModulesById(int courseId)
        {
            var Data = db.Modules.Where(x => x.CourseId == courseId);
            List<Module> allModules = Data.ToList();
            return allModules;
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

        public string GetCourseNameById(int courseId)
        {
            var Data = db.Courses.Where(x => x.Id == courseId).FirstOrDefault();
            if (Data != null) return Data.Name;
            return null;
        }

        public string GetModuleNameById(int moduleId)
        {
            var Data = db.Modules.Where(x => x.Id == moduleId).FirstOrDefault();
            if (Data != null) return Data.Name;
            return null;
        }
    }
}
