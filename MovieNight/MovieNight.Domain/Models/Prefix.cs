using MovieNight.Domain.Abstracts;

namespace MovieNight.Domain.Models
{
    public class Prefix : AThing //may have to change to Prefix/Title
    {
        public string Name { get; set; }

        public override bool IsValid()
        {
            return Validator.ValidateString(this);
        }
    }
}