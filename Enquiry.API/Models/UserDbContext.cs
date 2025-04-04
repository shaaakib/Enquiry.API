using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeFamily> EmployeeFamily { get; set; }
    }
}
