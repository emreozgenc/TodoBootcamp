using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Persistence.Todos
{
    public class TodoConfiguration : IEntityTypeConfiguration<Domain.Todos.Todo>
    {
        public void Configure(EntityTypeBuilder<Domain.Todos.Todo> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
                .ValueGeneratedNever();
        }
    }
}
