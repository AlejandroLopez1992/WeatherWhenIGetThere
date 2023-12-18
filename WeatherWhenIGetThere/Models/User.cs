using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherWhenIGetThere.Models
{
    public partial class User
    {
        private static int _nextid = 1;
        
        public User()
        {
            Id = _nextid;
            _nextid++;
           
        }

        public int Id { get; private set; }

        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
    }
}
