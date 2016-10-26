﻿using Microsoft.AspNet.Identity;
using System;

namespace IdentityPersistanceIgnorant.Identities
{
    public class IdentityUser : IUser<Guid>
    {
        public IdentityUser()
        {
            this.Id = Guid.NewGuid();
        }

        public IdentityUser(string userName)
            : this()
        {
            this.UserName = userName;
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
    }
}