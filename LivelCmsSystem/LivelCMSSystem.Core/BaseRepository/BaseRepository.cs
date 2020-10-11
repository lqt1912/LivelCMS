using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace LivelCMSSystem.Core.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Properties
        /// <summary>
        /// Gets or sets database context
        /// </summary>
        /// <value>The database context.</value>
        protected ApplicationDbContext DbContext { get; private set; }

        /// <summary>
        /// Gets or set database set
        /// </summary>
        /// <value>The database set.</value>
        private DbSet<T> DbSet { get; set; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}" /> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        protected BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        /// <summary>
        /// Finds the specified match.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <returns>T.</returns>
        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return DbSet.SingleOrDefault(match);
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <returns>IQueryable&lt;T&gt;.</returns>
        public virtual IQueryable<T> FindAll()
        {
            return DbSet;
        }

        /// <summary>
        /// Finds all asynchronous.
        /// </summary>
        /// <returns>IQueryable&lt;T&gt;.</returns>
        public virtual IQueryable<T> FindAllAsync()
        {
            return DbSet;
        }

        /// <summary>
        /// Finds the asynchronous.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await DbSet.SingleOrDefaultAsync(match);
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns>The <see cref="IQueryable" /></returns>
        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id">The identity</param>
        /// <returns>The model</returns>
        public virtual T GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        /// <summary>
        /// Gets the asynchronous by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public virtual async Task<T> GetAsyncById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        /// <summary>
        /// Gets or sets Get model by id as detached
        /// </summary>
        /// <param name="id">The identity</param>
        /// <returns>The entity object</returns>
        public virtual T GetByIdAsDetached(Guid id)
        {
            var entity = DbSet.Find(id);
            EntityEntry entityEntry = DbContext.Entry(entity);
            entityEntry.State = EntityState.Detached;
            return entity;
        }

        /// <summary>
        /// Add new entity object
        /// </summary>
        /// <param name="entity">The entity object</param>
        public virtual void Add(T entity)
        {
            EntityEntry entityEntry = DbContext.Entry(entity);
            if (entityEntry.State != EntityState.Detached)
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        /// <summary>
        /// Update the entity object
        /// </summary>
        /// <param name="entity">The entity object</param>
        public virtual void Update(T entity)
        {
            EntityEntry entityEntry = DbContext.Entry(entity);
            if (entityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            entityEntry.State = EntityState.Modified;
        }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public virtual int Count()
        {
            return DbSet.Count();
        }

        /// <summary>
        /// Counts the asynchronous.
        /// </summary>
        /// <returns>Task&lt;System.Int32&gt;.</returns>
        public virtual Task<int> CountAsync()
        {
            return DbSet.CountAsync();
        }

        /// <summary>
        /// Delete the entity object
        /// </summary>
        /// <param name="entity">The entity object</param>
        public virtual void Delete(T entity)
        {
            EntityEntry entityEntry = DbContext.Entry(entity);
            if (entityEntry.State != EntityState.Deleted)
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        /// <summary>
        /// Delete the entity object by id
        /// </summary>
        /// <param name="id">The identity</param>
        public virtual void Delete(Guid id)
        {
            var entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }

        /// <summary>
        /// Check the entity existed or not
        /// </summary>
        /// <param name="id">The identity</param>
        /// <returns>Is existed or not</returns>
        public bool Exists(Guid id)
        {
            return DbSet.Find(id) != null;
        }

        /// <summary>
        /// Save changes
        /// </summary>
        /// <returns>System.Int32.</returns>
        public virtual int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <returns>Task&lt;System.Int32&gt;.</returns>
        public virtual async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// list as an asynchronous operation.
        /// </summary>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        public virtual async Task<IEnumerable<T>> ListAsync()
        {
            var query = DbSet.AsNoTracking();
            return await query.ToListAsync();
        }

        /// <summary>
        /// list as an asynchronous operation.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        public virtual async Task<IEnumerable<T>> ListAsync(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            var query = DbSet.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        /// <summary>
        /// list as an asynchronous operation.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public virtual async Task<IEnumerable<T>> ListAsync(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null)
        {
            var query = DbSet.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                query = includeProperties(query);
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

      
    }
}
