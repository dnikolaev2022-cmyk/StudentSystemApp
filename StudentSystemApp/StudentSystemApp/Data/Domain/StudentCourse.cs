using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class StudentCourse
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int StudentId { get; set; } 
        public string StudentName { get; set;} = null!;
        public string StudentDescription { get; set;} = null!;
        public int StudentStudentId { get; set; } 


    }
}
