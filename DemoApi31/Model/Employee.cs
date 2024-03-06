using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace DemoApi31.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Department { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        // Navigation property to courses
       // [JsonIgnore]
      //  [IgnoreDataMember]
        
        public virtual ICollection<Course> Courses { get; set; }

        // Navigation property to certificates
       //  [JsonIgnore]
      //   [IgnoreDataMember]
        public virtual ICollection<Certificate> Certificates { get; set; }



    }
}
