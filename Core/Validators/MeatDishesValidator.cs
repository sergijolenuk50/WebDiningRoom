﻿using Data.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class MeatDishesValidator : AbstractValidator<CreateMeatDishesDto>
    {
        public MeatDishesValidator()
        {
            RuleFor(x => x.Name)
                 .NotEmpty()
                 .MinimumLength(2)
                 .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
        }
    }
}
