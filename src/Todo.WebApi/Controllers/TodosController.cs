using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Todo.Domain.Todos;

namespace Todo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TodoDto todoDto, CancellationToken cancellationToken)
        {
            var createdTodo = Domain.Todos.Todo.Create(todoDto);
            await _todoRepository.CreateAsync(createdTodo);
            return Ok(createdTodo);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todos = await _todoRepository.GetAllAsync();
            return Ok(todos);
        }
    }
}
