using Microsoft.EntityFrameworkCore;
using APW.Data;
using APW.Repositories;

using TaskEntity = APW.Models.Task;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITaskRepository, TaskRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();


app.MapGet("/tasks", async (ITaskRepository repo) =>
{
    var tasks = await repo.ReadAllAsync();
    return Results.Ok(tasks);
});


app.MapGet("/tasks/{id:int}", async (int id, ITaskRepository repo) =>
{
    var task = await repo.GetByIdAsync(id);
    return task is null ? Results.NotFound() : Results.Ok(task);
});


app.MapPost("/tasks", async (TaskEntity entity, ITaskRepository repo) =>
{
    var created = await repo.CreateAsync(entity);
    return Results.Created($"/tasks/{created.Id}", created);
});


app.MapPut("/tasks/{id:int}", async (int id, TaskEntity entity, ITaskRepository repo) =>
{
    if (id != entity.Id) return Results.BadRequest("El id del URL no coincide con el body.");

    var ok = await repo.UpdateAsync(entity);
    return ok ? Results.Ok(entity) : Results.NotFound();
});


app.MapDelete("/tasks/{id:int}", async (int id, ITaskRepository repo) =>
{
    var ok = await repo.DeleteAsync(id);
    return ok ? Results.Ok() : Results.NotFound();
});

app.Run();