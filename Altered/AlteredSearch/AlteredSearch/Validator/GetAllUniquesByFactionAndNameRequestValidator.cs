using AlteredSearch.Models.Requests;
using FluentValidation;

namespace AlteredSearch.Validator
{
    public class GetAllUniquesByFactionAndNameRequestValidator : AbstractValidator<GetAllUniquesByFactionAndNameRequest>
    {
        public GetAllUniquesByFactionAndNameRequestValidator()
        {
            RuleFor(x => x.Faction).ApplyFactionRules();
            RuleFor(x => x.Name).ApplyNameRules();
        }
    }
}
