using System;
using System.Collections.Generic;
using WebApp.DbHandler.Models;

namespace WebApp.Models.User
{
    public class ProfileModel
    {
        /* Personal information */
        public string Name { get; set; }
        public string Description { get; set; }
		public string StaffPosition { get; set; }
		
        /* Study information */
		public string University { get; set; }
		public string Study { get; set; }

        /* Social media */
        public string Website { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }

        /* Courses */
        public List<Course> WrittenCourses { get; set; }
    }
}
