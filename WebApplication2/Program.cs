var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:5000;http://localhost:7205");

var app = builder.Build();
app.Map("/index", () => "");
app.Map("/about/{name}", async (HttpContext context, string name) =>
{
    if(name == "Саня")
    {
        return "Саня - лох";
    }
    else if(name == "Влад")
    {
        context.Response.Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        return "";
    }
    else
    {
        return "Норм чел";
    }
});

app.Run();
