using System;
using System.Linq;

namespace WebApp.Helpers
{
    public static class SplitFullName
    {
        public static string PrintFirstName(string fullName)
        {
            return fullName.Split(" ").First();
        }

        public static string PrintLastName(string fullName)
        {
            return fullName.Split(" ").Last();
        }
    }
}
