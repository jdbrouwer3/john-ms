﻿using MovieNight.Domain.Abstracts;

namespace MovieNight.Domain.Models
{
    public class Rating : AThing
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid()
        {
            return Validator.ValidateString(this);
        }
    }
}