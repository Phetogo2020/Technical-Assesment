using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleApp.Service.Models;


namespace SimpleApp.Service.DAL
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;



        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Address> Address { get; set; }

    }
}
