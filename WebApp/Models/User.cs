using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseHandler.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Study { get; set; }
        public string Degree { get; set; }
        public bool Admin { get; set; }
        public bool Hidden { get; set; }
        public string RegDate { get; set; }
        public string LastLogin { get; set; }
        public string ImageUrl { get; set; }
    }
}
