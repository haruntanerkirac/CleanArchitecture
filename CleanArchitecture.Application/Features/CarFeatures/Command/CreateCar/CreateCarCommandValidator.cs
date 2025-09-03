using FluentValidation;

namespace CleanArchitecture.Application.Features.CarFeatures.Command.CreateCar
{
    public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Araç adı boş olamaz !");
            RuleFor(p => p.Name).NotNull().WithMessage("Araç adı boş olamaz !");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Araç adı en az 3 karakterden oluşmalıdır.");
            RuleFor(p => p.Model).NotEmpty().WithMessage("Araç Modeli boş olamaz !");
            RuleFor(p => p.Model).NotNull().WithMessage("Araç Modeli boş olamaz !");
            RuleFor(p => p.Model).MinimumLength(3).WithMessage("Araç Modeli en az 3 karakterden oluşmalıdır.");
            RuleFor(p => p.EnginePower).NotEmpty().WithMessage("Araç motor gücü boş olamaz !");
            RuleFor(p => p.EnginePower).NotNull().WithMessage("Araç motor gücü boş olamaz !");
            RuleFor(p => p.EnginePower).GreaterThan(0).WithMessage("Araç motor gücü 0 dan büyük olmalıdır.");
        }
    }
}
