namespace Web_Homework.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Person> People { get; set;}
    }
}
