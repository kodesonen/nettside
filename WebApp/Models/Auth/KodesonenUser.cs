using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Auth {

	public class KodesonenUser : IdentityUser {
		public string ApiKey { get; set; }
	}
}