namespace Application.Extensions.ActionResult;

public enum ResultType
{
    Success = 200,
    Unauthorized = 401,
    PermissionDenied = 403,
    NotFound = 404,
    Invalid = 500
}