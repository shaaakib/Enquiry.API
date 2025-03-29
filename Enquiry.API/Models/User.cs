using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime createdDate { get; set; }
        public string fullName { get; set; }
        public string mobileNo { get; set; }
    }
}
