using MediatR;

namespace Todo.Application.Features.Todos.GetAllTodos
{
    public record GetAllTodosQuery() : IRequest<IList<GetAllTodosResponse>>;
}
