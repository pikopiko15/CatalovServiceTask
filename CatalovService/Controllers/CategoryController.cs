using CatalovService.Data;
using Microsoft.AspNetCore.Mvc;

namespace CatalovService.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly CatalogDbContext _context;

        public CategoryController(CatalogDbContext context)
        {
            _context = context;
        }

        // todo
    }
}
