using System.Linq;
using ABPProject.EntityFramework;
using ABPProject.MultiTenancy;

namespace ABPProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPProjectDbContext _context;

        public DefaultTenantCreator(ABPProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
