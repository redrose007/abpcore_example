using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCoreProject.Configuration;

namespace MyCoreProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyCoreProjectWebCoreModule))]
    public class MyCoreProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyCoreProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCoreProjectWebHostModule).GetAssembly());
        }
    }
}
