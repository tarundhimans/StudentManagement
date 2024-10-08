using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public int RollNumber { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}