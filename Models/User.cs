using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models
{
    public class User
    {
       [Display(Name="First Name")]
       [Required]
       [MinLength(3)]
       public string FirstName { get; set; }

       [Display(Name="Last Name")]
       [Required]
       [MinLength(3)]
       public string LastName { get; set; }

       [Display(Name="Age")]
       [Required]
       public int Age { get; set; }

       [Display(Name="Email Address")]
       [Required]
       [EmailAddress]
       public string Email { get; set; }

       [Display(Name="Password")]
       [Required]
       [DataType(DataType.Password)]
       public string Password { get; set; }
    }
}