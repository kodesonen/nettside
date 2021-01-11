using Microsoft.AspNetCore.Identity;

namespace WebApp.DbHandler.Models
{
	public class User : IdentityUser
	{
		public bool Private { get; set; }
		public string ApiKey { get; set; }

		public string Description { get; set; }
		public string StaffPosition { get; set; }

		public string LinkedIn { get; set; }
		public string GitHub { get; set; }

		public string University { get; set; }
		public string Study { get; set; }
	}
}
