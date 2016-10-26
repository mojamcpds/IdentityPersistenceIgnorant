﻿using IdentityPersistanceIgnorant.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityPersistanceIgnorant.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByUserName(string username);
        Task<User> FindByUserNameAsync(string username);
        Task<User> FindByUserNameAsync(CancellationToken cancellationToken, string username);
    }
}
