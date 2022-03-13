WebApplicationOptions opts = new()
{
    Args = args,

    // If a folder named "wwwroot" exists, requests are preferentially served from it, disregarding this setting.
    // This is unfortunate because I want to switch the web root path depending on environment settings, without deleting the wwwroot folder.
    // An empty wwwroot-custom folder is also created if it does not exist. Perhaps that is undesirable behaviour also?
    WebRootPath = "wwwroot-custom",
};

var builder = WebApplication.CreateBuilder(opts);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
