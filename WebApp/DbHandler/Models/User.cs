using Microsoft.AspNetCore.Identity;

namespace WebApp.DbHandler.Models
{
	public class User : IdentityUser
	{
		public string ApiKey { get; set; }
	}
}
