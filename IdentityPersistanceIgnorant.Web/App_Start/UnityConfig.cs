using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Microsoft.AspNet.Identity;
using System;
using IdentityPersistanceIgnorant.Domain;
using IdentityPersistenceIgnorant.Data;
using IdentityPersistanceIgnorant.Identities;

namespace IdentityPersistanceIgnorant.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager(), new InjectionConstructor("IdentityPersistenceIgnorant"));
            container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            container.RegisterType<RoleStore>(new TransientLifetimeManager());
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}