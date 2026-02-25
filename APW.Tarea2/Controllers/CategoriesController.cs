using APW.Models;
using APW.Service.Managers;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryManager _manager;

    public CategoriesController(ICategoryManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetAll()
        => Ok(await _manager.ReadAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Category>> GetById(int id)
    {
        var item = await _manager.GetByIdAsync(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<Category>> Create(Category entity)
    {
        var created = await _manager.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.CategoryId }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, Category entity)
    {
        if (id != entity.CategoryId) return BadRequest("El id del route no coincide con el entity.Id");

        var ok = await _manager.UpdateAsync(entity);
        return ok ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var ok = await _manager.DeleteAsync(id);
        return ok ? NoContent() : NotFound();
    }
}