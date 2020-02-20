using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCoreProject.EntityFrameworkCore
{
    public static class MyCoreProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyCoreProjectDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);

        }

        public static void Configure(DbContextOptionsBuilder<MyCoreProjectDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);

        }
    }
}
