using Application.Extensions.ActionResult;

namespace Application.Errors;

public static partial class ErrorProvider
{
    public static class Owners
    {
        public static Result NotFound(int id) => Result.Invalid()
            .WithMessage("Организация не найдена")
            .WithError($"Id: {id}");
    }
}