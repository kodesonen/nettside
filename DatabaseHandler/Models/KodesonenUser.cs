using Microsoft.AspNetCore.Identity;

namespace WebApp.Models.Auth {

	public class KodesonenUser : IdentityUser {
		public string ApiKey { get; set; }
	}
}