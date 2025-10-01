using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IHotelService, HotelManager>();
builder.Services.AddSingleton<IHotelRepository, HotelRepository>();
builder.Services.AddSwaggerDocument(config=>
{
    config.PostProcess = document =>
    {
        document.Info.Version = "v1.0.13";
        document.Info.Title = "Hotel Finder API";
        document.Info.Description = "ASP.NET Core Web API for managing hotels";
        document.Info.Contact = new NSwag.OpenApiContact
        {
            Name = "Oðuz Anýl ATEÞ",
            Email = "atesanil8@gmail.com",
            Url = "https://github.com/OguzAnilAtes",
        };
    };
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();
app.UseOpenApi();
app.UseSwaggerUi();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
