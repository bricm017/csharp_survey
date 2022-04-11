using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_survey.Models
{
    public class User
    {
        [Required]
        public string name { get; set; }

        public string location { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Color must be at least 3 characters in length!")]
        public string comment { get; set; }


        [Range(-2000, 2000)]

        public string language { get; set; }
    }
}