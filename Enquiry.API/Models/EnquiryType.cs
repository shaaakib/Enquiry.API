using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    public class EnquiryType
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int typeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
    }
}
