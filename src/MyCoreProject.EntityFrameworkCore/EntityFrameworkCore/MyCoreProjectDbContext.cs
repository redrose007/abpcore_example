using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCoreProject.Authorization.Roles;
using MyCoreProject.Authorization.Users;
using MyCoreProject.MultiTenancy;
using Abp.Localization;

namespace MyCoreProject.EntityFrameworkCore
{
    public class MyCoreProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyCoreProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyCoreProjectDbContext(DbContextOptions<MyCoreProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationLanguageText>().Property(p => p.Value).HasMaxLength(500);
      
            base.OnModelCreating(modelBuilder);
        }
    }
}
