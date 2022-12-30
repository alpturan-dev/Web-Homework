using System.ComponentModel.DataAnnotations;

namespace Web_Homework.Models
{
    public class Role
    {
        public int RoleID { get; set; }

        [StringLength(30, ErrorMessage = "This field must have at least 5 characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "This field cannot be empty!")]
        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

        public List<Person> People { get; set; }
    }
}
