using Microsoft.EntityFrameworkCore;
using Todo.Domain.Todos;

namespace Todo.Persistence.Todos
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationContext _context;

        public TodoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Domain.Todos.Todo todo)
        {
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Domain.Todos.Todo>> GetAllAsync()
        {
            return await _context.Todos.ToListAsync();
        }
    }
}
