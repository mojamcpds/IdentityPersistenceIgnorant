﻿using Microsoft.AspNet.Identity;
using System;

namespace IdentityPersistanceIgnorant.Identities
{
    public class IdentityRole : IRole<Guid>
    {
        public IdentityRole()
        {
            this.Id = Guid.NewGuid();
        }

        public IdentityRole(string name)
            : this()
        {
            this.Name = name;
        }

        public IdentityRole(string name, Guid id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}