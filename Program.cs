using ASP_NET_HW_Module_02_part_02.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICocktailChoosing, CocktailChoosing>();
builder.Services.AddTransient<IMerceneryChoosing,MerceneryChoosing>();
builder.Services.AddTransient<IFigureIChoosing,FigureIChoosing>();
builder.Services.AddTransient<IDeviceChoosing,DeviceChoosing>();
builder.Services.AddControllersWithViews();


var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
