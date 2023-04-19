using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Model).NotEmpty();
            RuleFor(c => c.Model).MinimumLength(2);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => (int)c.ModelYear).GreaterThanOrEqualTo(2000);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(100);

        }
    }
}
