using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Models
{
    [Table("stateMaster")]
    public class State
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stateId { get; set; }
        public string stateName { get; set; }
    }
}
