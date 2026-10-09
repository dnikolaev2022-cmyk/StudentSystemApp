using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Course
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; } 

        public decimal Price { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
