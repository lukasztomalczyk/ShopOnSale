using System.Linq;
using ShopOnSale.services.Models;

namespace ShopOnSale.services.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int _id);
        IQueryable<T> GetAll();
    }
}