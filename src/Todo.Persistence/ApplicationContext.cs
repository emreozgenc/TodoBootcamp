using Microsoft.EntityFrameworkCore;

namespace Todo.Persistence
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Domain.Todos.Todo> Todos { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

    }
}
