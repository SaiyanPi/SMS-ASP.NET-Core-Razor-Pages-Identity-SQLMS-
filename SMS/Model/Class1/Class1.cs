using System.ComponentModel.DataAnnotations;

namespace SMS.Model.Class1
{
    public class Class1
    {
        [Key]
        public int Rollno { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string GuardianName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Role { get; set; }
        
    }
}
