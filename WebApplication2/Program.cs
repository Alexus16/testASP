var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Map("/index", () => "");
app.Map("/about/{name}", async (HttpContext context, string name) =>
{
    if(name == "����")
    {
        return "���� - ���";
    }
    else if(name == "����")
    {
        context.Response.Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        return "";
    }
    else
    {
        return "���� ���";
    }
});

app.Run();
