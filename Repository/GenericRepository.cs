using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericCrud.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext _context)
        {
            this._context = _context;
        }

        protected DbSet<T> EntitySet
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public async Task<List<T>> GetAll()
        {
            var allList = await EntitySet.ToListAsync();

            return allList;
        }

        public async Task<T> GetById(int id)
        {
            var Entity = await EntitySet.FindAsync(id);

            return Entity;
        }

        public async Task<T> Insert(T Entity)
        {
            var state = EntitySet.Add(Entity);
            await _context.SaveChangesAsync();
            return state.Entity;
        }

        public async Task Update(T Entity)
        {
            _context.Entry(Entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<T> Delete(int Id)
        {
            var Entity = await EntitySet.FindAsync(Id);
            var state = EntitySet.Remove(Entity);
            await _context.SaveChangesAsync();
            return state.Entity;
        }


    }
}
