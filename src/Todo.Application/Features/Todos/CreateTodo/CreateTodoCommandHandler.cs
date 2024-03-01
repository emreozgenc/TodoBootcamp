using MediatR;
using Todo.Domain.Todos;

namespace Todo.Application.Features.Todos.CreateTodo
{
    internal class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, CreateTodoResponse>
    {
        private readonly ITodoRepository _todoRepository;

        public CreateTodoCommandHandler(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<CreateTodoResponse> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = Domain.Todos.Todo.Create(
                Guid.NewGuid(),
                request.Title,
                request.Text,
                request.CreatedAt,
                request.DeadLine,
                request.Status,
                request.UserId);

            await _todoRepository.CreateAsync(todo);

            return new CreateTodoResponse(todo.Id);
        }
    }
}
