using Bmerketo.Contexts;
using Bmerketo.Helpers.Repositories;
using Bmerketo.Helpers.Services;
using Bmerketo.Models;
using Bmerketo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//contexts
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

//authentication
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount= false;
    x.User.RequireUniqueEmail= true;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.AccessDeniedPath= "/denied";
});


//repositories
builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<ContactFormRepository>();
builder.Services.AddScoped<ProductCategoryRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<UserRepository>();


//services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ShowCaseService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserAdminService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryService>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
