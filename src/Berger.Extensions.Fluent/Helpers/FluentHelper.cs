using FluentValidation;

namespace Berger.Extensions.Fluent
{
    public static class FluentHelper
    {
        public static IRuleBuilderOptions<T, TProperty> WithError<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string code, string message)
        {
            return rule
                .WithErrorCode(code)
                .WithMessage(message);
        }
    }
}