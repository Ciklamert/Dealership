using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Description).MinimumLength(2).WithMessage("Araba ismi minimum 2 karakter olmalıdır.");
            RuleFor(x => x.DailyPrice).GreaterThan(0).WithMessage("Arabanın günlük ücreti 0'dan büyük olmalıdır");
        }
    }
}
