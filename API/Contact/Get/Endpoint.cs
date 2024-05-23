using FastEndpoints;
using UseCase.DbContext;

namespace UseCase.API.Contact.Get;

internal sealed class Endpoint : Endpoint<Request,Response,Mapper>
{
    private AppDbContext Context { get; } = null!;
    
    public override void Configure()
    {
        Get("api/contact/{Id}");
    }
    
    public override async Task HandleAsync(Request re, CancellationToken ct)
    {
        var contact = await Context.Contacts.FindAsync(new object?[] { re.Id }, cancellationToken: ct);
        
        if (contact == null)
        {
            ThrowError("error", StatusCodes.Status404NotFound);
        }
        
        var response = Map.FromEntity(contact);
        await SendAsync(response, cancellation: ct);
    }
}