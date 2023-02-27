using FirelloProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FirelloProject.Controllers
{
    public class DemoController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;

        public DemoController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var connectionString = _configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            return Content(connectionString);

        }          
    }
}
