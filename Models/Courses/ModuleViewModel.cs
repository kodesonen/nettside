using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DbHandler.Models;

namespace WebApp.Models.Courses
{
	public class ModuleViewModel
	{
		public Module module { get; set; }
		public int CourseId { get; set; }
		public string courseName { get; set; }
		public string AuthorName { get; set; }
	}
}