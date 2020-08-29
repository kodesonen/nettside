using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseHandler.Dataset;
using DatabaseHandler.Models;
using WebApp.Models.Auth;

namespace DatabaseHandler.Handlers {

	public class HandleUsers {

		public static List<KodesonenUser> GetAllUsers() {
			using (var db = new DataContext()) {
				var Data = db.Users;
				List<KodesonenUser> Users = Data.ToList();
				return Users;
			}
		}
	}
}