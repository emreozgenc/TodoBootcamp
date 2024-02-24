using Todo.Domain.Abstractions;

namespace Todo.Domain.Todos
{
    public sealed class Todo : Entity
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime DeadLine { get; private set; }
        public TodoStatus Status { get; private set; }
        public Guid UserId { get; private set; }

        private Todo(Guid id, string title, string text, DateTime createdAt, DateTime deadLine, TodoStatus status, Guid userId) : base(id)
        {
            Title = title;
            Text = text;
            CreatedAt = createdAt;
            DeadLine = deadLine;
            Status = status;
            UserId = userId;

        }

        private Todo(TodoDto todoDto) : base(todoDto.Id)
        {
            Title = todoDto.Title;
            Text = todoDto.Text;
            CreatedAt = todoDto.CreatedAt;
            DeadLine = todoDto.DeadLine;
            Status = todoDto.Status;
            UserId = todoDto.UserId;
        }

        private Todo() : base(Guid.Empty)
        {

        }

        public static Todo Create(Guid id, string title, string text, DateTime createdAt, DateTime deadLine, TodoStatus status, Guid userId)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException(nameof(title));
            }

            if (title.Length > 50)
            {
                throw new ArgumentException("Title alanı 50 karakterden büyük olamaz!", nameof(title));
            }

            return new Todo(id, title, text, createdAt, deadLine, status, userId);
        }

        public static Todo Create(TodoDto todoDto)
        {
            if (string.IsNullOrWhiteSpace(todoDto.Title))
            {
                throw new ArgumentException(nameof(todoDto.Title));
            }

            if (todoDto.Title.Length > 50)
            {
                throw new ArgumentException("Title alanı 50 karakterden büyük olamaz!", nameof(todoDto.Title));
            }
            return new Todo(todoDto);
        }
    }
}
