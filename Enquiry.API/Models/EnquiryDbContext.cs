using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Models
{
    public class EnquiryDbContext : DbContext
    {
        public EnquiryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EnquiryStatus> EnquiryStatus { get; set; }
        public DbSet<EnquiryType> EnquiryType { get; set; }
        public DbSet<EnquiryModel> EnquiryModels { get; set; }
    }
}
