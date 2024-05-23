using FastEndpoints;

namespace UseCase.API.Contact.Create;

internal sealed class Mapper : Mapper<Request, Response, UseCase.Entities.Contact>
{
    public override UseCase.Entities.Contact ToEntity(Request request)
    {
        return new UseCase.Entities.Contact
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            DateOfBirth = request.DateOfBirth,
            Phone = request.Phone
        };
    }

    public override Response FromEntity(UseCase.Entities.Contact entity)
    {
        return new Response
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            DateOfBirth = entity.DateOfBirth,
            Phone = entity.Phone,
            Owner = entity.Owner
        };
    }
}