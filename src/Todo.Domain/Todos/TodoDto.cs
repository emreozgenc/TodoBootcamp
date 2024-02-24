namespace Todo.Domain.Todos
{
    public record TodoDto(
        Guid Id,
        string Title,
        string Text,
        DateTime CreatedAt,
        DateTime DeadLine,
        TodoStatus Status,
        Guid UserId);
}
