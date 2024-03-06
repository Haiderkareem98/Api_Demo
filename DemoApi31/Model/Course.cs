using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace DemoApi31.Model
{
    public class Course
    { 
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public int Evaluation { get; set; }

        // Foreign key to Employee
        public int EmployeeId { get; set; }

        // Navigation property to employee
        [ForeignKey("EmployeeId")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Employee? Employee { get; set; }
    }
}

