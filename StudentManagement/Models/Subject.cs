    using StudentManagement.Models;
    using System.ComponentModel.DataAnnotations;

    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Languages { get; set; }  // Comma-separated string for multiple languages

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
