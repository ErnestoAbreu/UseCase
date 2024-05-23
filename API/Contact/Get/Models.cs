using System.ComponentModel.DataAnnotations;
using FastEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace UseCase.API.Contact.Get;

internal sealed class Request
{
    public string? Id { get; set; }
}

internal sealed class Validator : Validator<Request>
{
    public Validator()
    {
    }
}

internal sealed class Response
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public Guid Owner { get; set; }
}
