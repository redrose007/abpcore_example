using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCoreProject.Configuration;
using MyCoreProject.Web;

namespace MyCoreProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyCoreProjectDbContextFactory : IDesignTimeDbContextFactory<MyCoreProjectDbContext>
    {
        public MyCoreProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyCoreProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyCoreProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyCoreProjectConsts.ConnectionStringName));

            return new MyCoreProjectDbContext(builder.Options);
        }
    }
}
