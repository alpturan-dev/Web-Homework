using System.ComponentModel.DataAnnotations;

namespace Web_Homework.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [StringLength(30, ErrorMessage = "This field must have at least 5 characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "This field cannot be empty!")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Person> People { get; set; }
    }
}
