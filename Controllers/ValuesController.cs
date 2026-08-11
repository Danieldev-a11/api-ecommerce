using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new();

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = Products.Count + 1;

        Products.Add(product);

        return CreatedAtAction(
            nameof(GetById),
            new { id = product.Id },
            product
        );
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound("Produto não encontrado.");

        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        var existingProduct = Products.FirstOrDefault(p => p.Id == id);

        if (existingProduct == null)
            return NotFound("Produto não encontrado.");

        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.Stock = product.Stock;
        existingProduct.Category = product.Category;

        return Ok(existingProduct);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound("Produto não encontrado.");

        Products.Remove(product);

        return NoContent();
    }
}
