using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static readonly List<Customer> Customers = new();

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.Id = Customers.Count + 1;

            Customers.Add(customer);

            return Ok(customer);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }
    }

}
