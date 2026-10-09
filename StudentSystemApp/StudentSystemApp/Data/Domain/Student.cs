using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Required]


        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}

