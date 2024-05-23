using FastEndpoints;
using FluentValidation;

namespace UseCase.API.Contact.Create;

internal sealed class Request
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Phone { get; set; }
}

internal sealed class Validator : Validator<Request>
{
    public Validator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.");
        RuleFor(x => x.FirstName).MaximumLength(128).WithMessage("First name is too long.");

        RuleFor(x => x.LastName).MaximumLength(128).WithMessage("Last name is too long.");

        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid.");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required.");

        RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("Date of birth is required.");
        RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now).WithMessage("Date of birth is not valid.");

        RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required.");
    }
}

internal sealed class Response
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public Guid Owner { get; set; }
}