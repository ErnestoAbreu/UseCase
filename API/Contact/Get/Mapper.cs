using FastEndpoints;

namespace UseCase.API.Contact.Get;
internal sealed class Mapper : Mapper<Request,Response,Entities.Contact>
{
    public override Response FromEntity(Entities.Contact entity)
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