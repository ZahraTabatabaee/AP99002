using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class User{
        [Required]
        public string FirstName{get; set;}
        [Required]
        public string LastName{get; set;}
        [Required] 
        [EmailAddress]
        public string Email{get; set;}
    }
}