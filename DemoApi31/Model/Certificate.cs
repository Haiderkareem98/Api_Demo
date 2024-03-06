using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace DemoApi31.Model
{
    public class Certificate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Grade { get; set; }

        // Foreign key to Employee
        public int EmployeeId { get; set; }

        // Navigation property to employee
        [ForeignKey("EmployeeId")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Employee? Employee { get; set; }
    }
}
