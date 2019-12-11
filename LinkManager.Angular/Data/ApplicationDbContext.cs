using LinkManager.Angular.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ApplicationUser = LinkManager.Angular.Models.ApplicationUser;

namespace LinkManager.Angular.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LinkTags>().HasKey(_ => new { _.LinkId, _.TagId });
            builder.Entity<LinkTags>().HasOne(_ => _.Link).WithMany(_ => _.LinkTags).HasForeignKey(_ => _.LinkId);
            builder.Entity<LinkTags>().HasOne(_ => _.Tag).WithMany(_ => _.LinkTags).HasForeignKey(_ => _.TagId);
            base.OnModelCreating(builder);
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<LinkTags> LinkTags { get; set; }
    }
}
