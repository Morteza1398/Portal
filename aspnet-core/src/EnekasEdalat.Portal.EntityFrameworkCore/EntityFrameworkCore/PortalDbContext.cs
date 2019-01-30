using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EnekasEdalat.Portal.Authorization.Roles;
using EnekasEdalat.Portal.Authorization.Users;
using EnekasEdalat.Portal.MultiTenancy;

namespace EnekasEdalat.Portal.EntityFrameworkCore
{
    public class PortalDbContext : AbpZeroDbContext<Tenant, Role, User, PortalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }
    }
}
