using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace MostafaProject.Models
{
    public class User
    {

        public string Name { get; set; }
        public string Family { get; set; }
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PassWrod { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("PassWrod", ErrorMessage = "کلمات عبور باهم یکسان نیستند")]
        public string RePassWrod { get; set; }
    }
}
