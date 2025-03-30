using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    [Table("districtMaster")]
    public class District
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int districtId { get; set; }
        public string districtName { get; set; }
        public int stateId { get; set; }
    }
}
