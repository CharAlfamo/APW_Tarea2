using APW.Models;
using APW.Service.Managers;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    private readonly IRoleManager _manager;

    public RolesController(IRoleManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<List<Role>>> GetAll()
        => Ok(await _manager.ReadAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Role>> GetById(int id)
    {
        var role = await _manager.GetByIdAsync(id);
        return role is null ? NotFound() : Ok(role);
    }

    [HttpPost]
    public async Task<ActionResult<Role>> Create([FromBody] Role entity)
    {
        var created = await _manager.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.RoleId }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] Role entity)
    {
        if (entity.RoleId != id) return BadRequest("El id del body no coincide con el id de la ruta.");

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