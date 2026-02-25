using APW.Models;
using APW.Service.Managers;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserRolesController : ControllerBase
{
    private readonly IUserRoleManager _manager;

    public UserRolesController(IUserRoleManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserRole>>> Get()
        => Ok(await _manager.ReadAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<UserRole>> GetById(int id)
    {
        var item = await _manager.GetByIdAsync(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<UserRole>> Create(UserRole entity)
    {
        var created = await _manager.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, UserRole entity)
    {
        if (id != entity.Id) return BadRequest();
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