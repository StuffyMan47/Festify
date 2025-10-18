namespace Application.Models.PaginatedModels;

public class PaginatedRequest
{
    public string? Name { get; init; }
    public long Cursor { get; init; }
    public int PageSize { get; init; }
}