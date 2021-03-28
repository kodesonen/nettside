using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApp.DbHandler.Models;
using WebApp.Models.Admin;

namespace WebApp.DbHandler.Interfaces
{
    public interface ICourseHandler
    {
        public List<Course> LoadAll();
        public List<Module> GetAllModules();
        public Module GetModuleById(int moduleId);
        public List<Module> GetModulesByCourseId(int courseId);
        public bool AddNewCourse(Course model);
        public bool AddNewModule(Module model);
        public string GetCourseNameById(int courseId);
        public string GetModuleNameById(int moduleId);
        public Course GetCourseById(int courseId);
        public bool UpdateCourse(Course model);
        public bool UpdateModule(Module model);
		public List<Course> GetAllCoursesByUserId(string userId);
        public List<Module> GetAllModulesByUserId(string userId);
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

        public List<Module> GetModulesByCourseId(int courseId)
        {
            var Data = db.Modules.Where(x => x.CourseId == courseId);
            List<Module> allModules = Data.ToList();
            return allModules;
        }

        public bool AddNewCourse(Course model)
        {
            //Course newCourse = new Course() {
            //	Name = model.Name,
            //	Description = model.Description,
            //	Icon = model.Icon
            //};

            //Den koden er vel unødvendig? ^

            db.Courses.Add(model);
            db.SaveChanges();

            /* Burde antakeligvis være noe feilsjekk her */
            return true;
        }

        public bool AddNewModule(Module model)
        {
            db.Modules.Add(model);
            db.SaveChanges();

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
            if (Data != null) return Data.ModuleName;
            return null;
        }

        public Course GetCourseById(int courseId)
        {
            var course = db.Courses.Where(x => x.Id == courseId);
            if (!course.Any())
            {
                Console.WriteLine($"ERROR: Could not find course with id: {courseId}");
                return new Course();
            }
            return course.First();
        }

        public bool UpdateCourse(Course model)
        {
            db.Courses.Update(model);
            var result = db.SaveChanges();
            //Returns true if more than 0 rows affected
            return result > 0;
        }

        public bool UpdateModule(Module model)
        {
            db.Modules.Update(model);
            var result = db.SaveChanges();
            //Returns true if more than 0 rows affected
            return result > 0;
        }

        public Module GetModuleById(int moduleId)
        {
            var Data = db.Modules.Where(x => x.Id == moduleId);
            Module allModules = Data.FirstOrDefault();
            return allModules;
        }

		public List<Course> GetAllCoursesByUserId(string userId)
		{
			/* Todo: gruppering av antall courses */
			var Data = db.Modules.Where(x => x.Author == userId);
            List<Module> listOfModules = Data.ToList();

			List<Course> listOfCourses = new List<Course>();
			foreach(var module in listOfModules)
			{
				var course = db.Courses.Where(x => x.Id == module.CourseId).FirstOrDefault();
				listOfCourses.Add(course);
			}

            return listOfCourses;
		}

        public List<Module> GetAllModulesByUserId(string userId)
		{
			var Data = db.Modules.Where(x => x.Author == userId);
            List<Module> listOfModules = Data.ToList();
            return listOfModules;
		}
    }
}
