using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopOnSale.services.Context;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Models.Base;

namespace ShopOnSale.services.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }
        public T GetById(int _id)
        {
            throw new System.NotImplementedException();
        }

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _dbSet;
            return query;
        }
    }
}