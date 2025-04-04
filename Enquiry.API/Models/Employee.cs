using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    [Table("employeeMaster")]
    public class Employee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        public string name { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string projectName { get; set; }
        public string city { get; set; }
        public string address { get; set; }
    }
}
