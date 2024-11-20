List<string> nominatedNames =["Andreas", "Harald"];

Election election = new Election(nominatedNames);


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.Run();