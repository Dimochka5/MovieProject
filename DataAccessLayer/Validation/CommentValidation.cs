﻿using FluentValidation;
using DataAccessLayer.Models;

namespace DataAccessLayer.Validation
{
    public class CommentValidation : Validation<Comment>
    {
        public CommentValidation()
        {
            RuleFor(c => c.IdMovie).NotNull();
            RuleFor(c => c.IdUser).NotNull();
            RuleFor(c => c.Text).NotNull().MinimumLength(1).MaximumLength(5000);
        }
    }
}
