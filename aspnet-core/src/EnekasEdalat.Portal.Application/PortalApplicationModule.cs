using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EnekasEdalat.Portal.Authorization;

namespace EnekasEdalat.Portal
{
    [DependsOn(
        typeof(PortalCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PortalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PortalAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PortalApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
