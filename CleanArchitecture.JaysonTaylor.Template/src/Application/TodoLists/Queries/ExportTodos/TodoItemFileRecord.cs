using CleanArchitecture.JT.Application.Common.Mappings;
using CleanArchitecture.JT.Domain.Entities;

namespace CleanArchitecture.JT.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
