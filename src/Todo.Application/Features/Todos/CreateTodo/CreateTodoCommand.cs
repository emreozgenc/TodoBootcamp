using MediatR;
using Todo.Domain.Todos;

namespace Todo.Application.Features.Todos.CreateTodo
{
    public record class CreateTodoCommand(
        string Title,
        string Text,
        DateTime CreatedAt,
        DateTime DeadLine,
        TodoStatus Status,
        Guid UserId) : IRequest<CreateTodoResponse>;
}
