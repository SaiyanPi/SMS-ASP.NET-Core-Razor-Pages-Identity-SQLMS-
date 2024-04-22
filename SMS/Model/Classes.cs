using System.ComponentModel.DataAnnotations;

namespace SMS.Model
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ClassTeacher { get; set; }
        public string ClassCaptain { get; set; }
        public string ClassFirst { get; set; }
        public string ClassSecond { get; set; }
        public string ClassThird { get; set; }
        public int TotalStudent { get; set; }
    }
}
