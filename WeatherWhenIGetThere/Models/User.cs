using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherWhenIGetThere.Models
{
    public class User
    {
        private static int _nextId = 1;
        
        public User()
        {
            if (Id == default)
            {
                Id = _nextId;
                _nextId++;
            }
        }

        public int Id { get; private set; }

        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
    }
}
