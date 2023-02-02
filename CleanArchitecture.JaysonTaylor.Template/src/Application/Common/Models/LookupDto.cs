using CleanArchitecture.JT.Application.Common.Mappings;
using CleanArchitecture.JT.Domain.Entities;

namespace CleanArchitecture.JT.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
