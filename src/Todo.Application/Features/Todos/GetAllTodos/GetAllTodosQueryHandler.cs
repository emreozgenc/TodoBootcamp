using MediatR;
using Todo.Domain.Todos;

namespace Todo.Application.Features.Todos.GetAllTodos
{
    internal class GetAllTodosQueryHandler : IRequestHandler<GetAllTodosQuery, IList<GetAllTodosResponse>>
    {
        private readonly ITodoRepository _todoRepository;

        public GetAllTodosQueryHandler(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IList<GetAllTodosResponse>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            var todos = await _todoRepository.GetAllAsync();

            return todos.Select(t => new GetAllTodosResponse(t.Title, t.Text)).ToList();
        }
    }
}
