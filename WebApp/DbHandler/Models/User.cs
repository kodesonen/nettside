using Microsoft.AspNetCore.Identity;

namespace WebApp.DbHandler.Models
{
	public class User : IdentityUser
	{
		/* Personal information */
		public string FullName { get; set; }
		public string UrlName { get; set; }
		public string Description { get; set; }
		public string StaffPosition { get; set; }
		public bool Private { get; set; }

		/* Social media */
        public string Website { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }

		/* Study information */
		public string University { get; set; }
		public string Study { get; set; }

		/* API information */
		public string ApiKey { get; set; }
	}
}
