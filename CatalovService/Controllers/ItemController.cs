using CatalovService.Data;
using Microsoft.AspNetCore.Mvc;

namespace CatalovService.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemController : ControllerBase
    {
        private readonly CatalogDbContext _context;

        public ItemController(CatalogDbContext context)
        {
            _context = context;
        }

        // todo
    }
}
