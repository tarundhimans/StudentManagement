using FluentValidation;
using StudentManagement.Models;

namespace StudentManagement.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Age).InclusiveBetween(5, 100).WithMessage("Age must be between 5 and 100");
            RuleFor(x => x.RollNumber).NotEmpty().WithMessage("Roll number is required");
            RuleFor(x => x.Class).NotEmpty().WithMessage("Class is required");
        }
    }
}
