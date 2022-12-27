using System.ComponentModel.DataAnnotations;

namespace Web_Homework.Models
{
    public class PersonCategory
    {
        public int PersonCategoryID { get; set; }

        [StringLength(30, ErrorMessage = "This field must have at least 5 characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "This field cannot be empty!")]
        public string PersonCategoryName { get; set; }

        public string PersonCategoryDescription { get; set; }

        public List<Person> People { get; set; }
    }
}
