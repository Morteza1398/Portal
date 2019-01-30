using Abp.MultiTenancy;
using EnekasEdalat.Portal.Authorization.Users;

namespace EnekasEdalat.Portal.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
