List<string> nominatedNames =["Andreas", "Harald"];

Election election = new Election(nominatedNames);


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.MapGet("/election/nominee", () => 
{
    return election.ListNominees();
});

app.MapPost("/election/vote", (VoteDTO vote) => 
{
    Vote? voteReceipt = election.CastVote(vote.Nominee);
    if (voteReceipt == null)
    {
        return Results.BadRequest();
    } else 
    {
        return Results.Ok();
    }
});

app.Run();