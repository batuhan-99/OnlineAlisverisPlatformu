using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Entities
{
    public enum UserRole
    {
        Admin,
        Customer
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
