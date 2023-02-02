using CleanArchitecture.JT.Application.Common.Mappings;
using CleanArchitecture.JT.Domain.Entities;

namespace CleanArchitecture.JT.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
