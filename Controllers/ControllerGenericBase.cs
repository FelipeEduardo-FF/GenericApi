using GenericCrud.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrud.Controllers
{
    public class ControllerGenericBase<T>:ControllerBase where T : class
    {
        private readonly AppDbContext _context;
        private readonly GenericRepository<T> _repository;

        public ControllerGenericBase(AppDbContext _context)
        {
            this._context = _context;
            this._repository = new GenericRepository<T>(_context);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repository.GetAll());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await _repository.GetById(Id));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await _repository.Delete(Id));
        }

        [HttpPost()]
        public async Task<IActionResult> Insert(T Entity)
        {
            return Ok(await _repository.Insert(Entity));
        }

        [HttpPut()]
        public async Task<IActionResult> Update(T Entity)
        {
            await _repository.Update(Entity);
            return NoContent();
        }


    }
}
