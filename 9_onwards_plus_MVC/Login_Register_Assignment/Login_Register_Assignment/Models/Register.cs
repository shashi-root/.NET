using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_Register_Assignment.Models
{
    public class Register
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Phone][Required]
        public string Mobile { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        public Boolean Remember { set; get; }
    }
}