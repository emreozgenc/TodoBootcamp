using Todo.Domain.Abstractions;

namespace Todo.Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id) : base(id)
        {
        }
    }
}
