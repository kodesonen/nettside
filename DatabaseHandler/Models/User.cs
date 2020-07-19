using System;
using System.Collections.Generic;

namespace DatabaseHandler.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Pet> Pets { get; set; }
    }
}
