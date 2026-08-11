using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private static readonly List<Order> Orders = new();

    [HttpPost]
    public IActionResult Create(Order order)
    {
        order.Id = Orders.Count + 1;
        order.Status = "Pending";

        Orders.Add(order);

        return Ok(order);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Orders);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var order = Orders.FirstOrDefault(o => o.Id == id);

        if (order == null)
            return NotFound();

        return Ok(order);
    }

    [HttpPut("{id}/approve")]
    public IActionResult Approve(int id)
    {
        var order = Orders.FirstOrDefault(o => o.Id == id);

        if (order == null)
            return NotFound();

        order.Status = "Approved";

        return Ok(order);
    }
}
