using Microsoft.AspNetCore.Identity;

namespace WebApp.DbHandler.Models
{
	public class User : IdentityUser
	{
		public string ApiKey { get; set; }
		public string TestColumn { get; set; }
		public bool Private { get; set; }
	}
}
