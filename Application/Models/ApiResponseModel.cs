namespace Application.Models;

public class ApiResponseModel
{
    public ApiResponseErrors? Errors { get; init; }
}

public class BaseApiResponseModel<T> : ApiResponseModel
{
    public T? Data { get; init; }
}
