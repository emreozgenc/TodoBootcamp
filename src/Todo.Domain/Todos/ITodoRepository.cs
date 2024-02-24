namespace Todo.Domain.Todos
{
    public interface ITodoRepository
    {
        Task CreateAsync(Todo todo);
        Task<IList<Todo>> GetAllAsync();
    }
}
