using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherWhenIGetThere.Models
{
    public class User
    {
        private static int _nextid = 1;
        
        public User()
        {
            Id = _nextid;
            _nextid++;
           
        }

        public int Id { get; private set; }

        public string? Name { get; set; }

        [System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple = false)]
        public sealed class EmailAddressAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
        {
            public EmailAddressAttribute(DataType dataType) : base(dataType)
            {
            }
        }
    }
}
