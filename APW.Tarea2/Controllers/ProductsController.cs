using APW.Models;
using APW.Service.Managers;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductManager _manager;

    public ProductsController(IProductManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> Get()
        => Ok(await _manager.ReadAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var item = await _manager.GetByIdAsync(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Create(Product entity)
    {
        var created = await _manager.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.ProductId }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, Product entity)
    {
        if (id != entity.ProductId) return BadRequest();

        var updated = await _manager.UpdateAsync(entity);
        return updated ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _manager.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}