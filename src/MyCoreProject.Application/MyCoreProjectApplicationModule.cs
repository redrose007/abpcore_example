using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCoreProject.Authorization;

namespace MyCoreProject
{
    [DependsOn(
        typeof(MyCoreProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyCoreProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyCoreProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyCoreProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
