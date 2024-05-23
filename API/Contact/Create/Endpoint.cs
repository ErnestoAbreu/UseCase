using FastEndpoints;
using UseCase.DbContext;

namespace UseCase.API.Contact.Create;

internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
{
    private AppDbContext Context { get; set; } = null!;

    public override void Configure()
    {
        Post("api/contact");
    }

    public override async Task HandleAsync(Request re, CancellationToken ct)
    {
        var result = await Context.Contacts.AddAsync(Map.ToEntity(re), ct);
        await Context.SaveChangesAsync(ct);

        SendAsync(new Response());
    }
}