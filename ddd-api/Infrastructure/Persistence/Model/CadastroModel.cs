﻿using Domain.Modules.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Model
{
    public partial class DefaultDataBaseContext : GenericContext
    {
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}
