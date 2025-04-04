using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    [Table("employeeFamily")]
    public class EmployeeFamily
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int familyId { get; set; }
        public int employeeId { get; set; }
        public string name { get; set; }
        public string relation { get; set; }
        public int age { get; set; }
    }
}
