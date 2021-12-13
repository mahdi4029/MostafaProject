using System.ComponentModel.DataAnnotations;

namespace MostafaProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "نام کتاب")]
        public string BookName { get; set; }

        [Display(Name = "نویسنده")]
        public string Author { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "قیمت")]
        public int Price { get; set; }
        public bool IsDelete { get; set; } = true;
    }
}
