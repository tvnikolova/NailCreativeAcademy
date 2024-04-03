﻿namespace NailCreativeAcademy.Infrastructure.Data.Common
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class Repository : IRepository
    {
        private readonly NailCreativeDbContext nailContext;
        public Repository(NailCreativeDbContext context)
        {
            this.nailContext = context;

        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return nailContext.Set<T>();
        }
        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await nailContext.SaveChangesAsync();
        }
    }
}
