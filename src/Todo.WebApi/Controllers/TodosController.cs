using MediatR;
using Microsoft.AspNetCore.Mvc;
using Todo.Application.Features.Todos.CreateTodo;
using Todo.Application.Features.Todos.GetAllTodos;
using Todo.Domain.Todos;

namespace Todo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMediator _mediator;

        public TodosController(ITodoRepository todoRepository, IMediator mediator)
        {
            _todoRepository = todoRepository;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllTodosQuery());
            return Ok(response);
        }
    }
}
