using GenericCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrud.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DriverController : ControllerGenericBase<Driver>
    {
        public DriverController(AppDbContext _context) : base(_context)
        {
        }
    }
}
