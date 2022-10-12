
//using ASP.NETWeb;
//using ASP.NETWeb.Models;
using ServiceLifeTime;
using ServiceLifeTime.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITransientService, OperationServices>();
builder.Services.AddSingleton<ISingletonService, OperationServices>();
builder.Services.AddScoped<IScopedService, OperationServices>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
//app.UseWelcomePage();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
