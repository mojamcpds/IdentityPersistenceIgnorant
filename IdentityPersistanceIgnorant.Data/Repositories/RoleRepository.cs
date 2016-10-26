using IdentityPersistanceIgnorant.Domain.Models;
using IdentityPersistanceIgnorant.Domain.Repositories;
using IdentityPersistenceIgnorant.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityPersistanceIgnorant.Data.Repositories
{
    internal class RoleRepository : Repository<Role>, IRoleRepository
    {
        internal RoleRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Role FindByName(string roleName)
        {
            return Set.FirstOrDefault(x => x.Name == roleName);
        }

        public Task<Role> FindByNameAsync(string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName);
        }

        public Task<Role> FindByNameAsync(System.Threading.CancellationToken cancellationToken, string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName, cancellationToken);
        }
    }
}