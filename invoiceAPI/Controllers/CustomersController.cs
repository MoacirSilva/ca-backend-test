using Microsoft.AspNetCore.Mvc;

namespace invoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly string _connectionString;
        public CustomersController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MyLocalDb");
        }
    }
}
