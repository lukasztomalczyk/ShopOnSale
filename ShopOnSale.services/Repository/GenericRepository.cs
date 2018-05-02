using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopOnSale.services.Context;
using ShopOnSale.services.Interface;
using ShopOnSale.services.Models.Base;

namespace ShopOnSale.services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }
        public virtual T GetById(int _id)
        {
           return _dbSet.SingleOrDefault(x => x.Id ==_id);
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _dbSet;
            return query;
        }
    }
}