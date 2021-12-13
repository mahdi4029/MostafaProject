using System.ComponentModel.DataAnnotations;

namespace MostafaProject.Models
{
    public class Admin
    {
        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}
