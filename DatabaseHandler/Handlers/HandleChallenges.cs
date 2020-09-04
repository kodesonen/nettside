using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseHandler.Dataset;
using DatabaseHandler.Models;

namespace DatabaseHandler.Handlers {

	public class HandleChallenges {

		public static List<Challenge> GetAllChallenges() {
			//using (var db = new DataContext()) {
			//	var Data = db.Challenges;
			//	List<Challenge> ChallengesList = Data.ToList();
			//	return ChallengesList;
			//}

			return new List<Challenge>();
		}
	}
}