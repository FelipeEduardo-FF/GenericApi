namespace GenericCrud.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Delete(int Id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T Entity);
        Task Update(T Entity);
    }
}