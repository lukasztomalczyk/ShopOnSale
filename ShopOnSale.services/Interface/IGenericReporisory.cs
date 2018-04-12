namespace ShopOnSale.services.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int _id);
    }
}