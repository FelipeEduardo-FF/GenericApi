using GenericCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrud.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SystemInfoController : ControllerGenericBase<SystemInfo>
    {
        public SystemInfoController(AppDbContext _context) : base(_context)
        {
        }
    }
}
