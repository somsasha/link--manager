using LinkManager.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinkManager.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LinkTags>().HasKey(_ => new {_.LinkId, _.TagId});
            builder.Entity<LinkTags>().HasOne(_ => _.Link).WithMany(_ => _.LinkTags).HasForeignKey(_ => _.LinkId);
            builder.Entity<LinkTags>().HasOne(_ => _.Tag).WithMany(_ => _.LinkTags).HasForeignKey(_ => _.TagId);
            base.OnModelCreating(builder);
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<LinkTags> LinkTags { get; set; }
    }
}
