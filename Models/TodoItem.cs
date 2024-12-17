namespace TodoApp.Models;

using TodoApp.Enums;

public class TodoItem
{
    public required int Id { get; set; }
    
    public required string Title { get; set; }
    
    public required string Description { get; set; }
    
    public required Priority Priority { get; set; }
    
    public required DateTime DueDate { get; set; }
}