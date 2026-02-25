using APW.Models;
using APW.Service.Managers;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoriesController : ControllerBase
{
    private readonly IInventoryManager _manager;

    public InventoriesController(IInventoryManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<List<Inventory>>> Get()
        => Ok(await _manager.ReadAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Inventory>> GetById(int id)
    {
        var item = await _manager.GetByIdAsync(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<Inventory>> Create(Inventory entity)
    {
        var created = await _manager.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.InventoryId }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, Inventory entity)
    {
        if (id != entity.InventoryId) return BadRequest();

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