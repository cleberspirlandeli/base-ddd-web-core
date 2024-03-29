﻿using Infrastructure.Persistence.Model;
using System;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork.Base
{
    public class GenericUnitOfWork
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly DefaultDataBaseContext _context;

        public GenericUnitOfWork(DefaultDataBaseContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public virtual async Task CommitAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
