using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TopTrumpsNovus.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.SqlClient;
using Azure;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper;
using TopTrumpsNovus.Models;

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


using (var reader = new StreamReader("filePersons.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var records = csv.GetRecords<CardConst>();
}

string connetionString;
SqlConnection cnn;

connetionString = "Server=(localdb)\\mssqllocaldb;Database=TopTrumpsNovus.Data;Trusted_Connection=True;MultipleActiveResultSets=true";

cnn = new SqlConnection(connetionString);
cnn.Open();

SqlDataAdapter adapter = new SqlDataAdapter();


var insertQuery = "INSERT INTO Card (DeckID, CardName, ImageFilePath, StatOne, StatTwo, StatThree, StatFour, StatFive, StatSix) " +
               "VALUES (4, 'Test', 'Test.png', 1, 2, 3, 4, 5, 6)";

SqlCommand command = new SqlCommand(insertQuery, cnn);
adapter.InsertCommand = new SqlCommand(insertQuery, cnn);
adapter.InsertCommand.ExecuteNonQuery();

command.Dispose();

// Response.Write("Connection MAde");
cnn.Close();

app.Run();