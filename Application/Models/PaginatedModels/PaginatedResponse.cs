namespace Application.Models.PaginatedModels;

public class PaginatedApiResponseModel<T> : BaseApiResponseModel<T>
{
    public long Cursor { get; init; }
}