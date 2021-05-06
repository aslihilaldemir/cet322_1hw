using System;
namespace cet322_firstwork.Models
{
    public class Student
    {
        public Student()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public DateTime Birthdate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}
