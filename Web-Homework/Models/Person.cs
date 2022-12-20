﻿namespace Web_Homework.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PersonPhone { get; set; }
        public string PersonEmail { get; set; }
        public string CategoryID  { get; set; }
        public virtual Category Category { get; set; }

    }
}
