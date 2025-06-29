using FluentValidation;

namespace AlteredSearch.Validator;

public static class ValidationRules
{
    public static IRuleBuilderOptions<T, string> ApplyFactionRules<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty().WithMessage("Facção é obrigatória.")
            .MaximumLength(50).WithMessage("Facção deve ter no máximo 50 caracteres.");
    }

    public static IRuleBuilderOptions<T, string> ApplyNameRules<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .MaximumLength(100).WithMessage("Nome deve ter no máximo 100 caracteres.");
    }
}
