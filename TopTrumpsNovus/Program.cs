using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TopTrumpsNovus.Data;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CardDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CardDBContext") ?? throw new InvalidOperationException("Connection string 'CardDBContext' not found.")));
var connectionString = builder.Configuration.GetConnectionString("TopTrumpsNovusContextConnection") ?? throw new InvalidOperationException("Connection string 'TopTrumpsNovusContextConnection' not found.");

builder.Services.AddDbContext<TopTrumpsNovusContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TopTrumpsNovusContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
