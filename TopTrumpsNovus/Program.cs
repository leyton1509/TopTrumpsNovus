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
using System.Runtime.Intrinsics.X86;
using System.IO;

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
    pattern: "{controller=Card}/{action=BasketBall}/{id?}");

/*
string connetionString;
SqlConnection cnn;

connetionString = "Server=(localdb)\\mssqllocaldb;Database=TopTrumpsNovus.Data;Trusted_Connection=True;MultipleActiveResultSets=true";

cnn = new SqlConnection(connetionString);
cnn.Open();

SqlDataAdapter adapter = new SqlDataAdapter();


string[] lines = System.IO.File.ReadAllLines("DecksP.csv");
foreach (string line in lines)
{
    string[] columns = line.Split(',');

    Console.WriteLine(columns[0] + " " + columns[1] + " " + columns[2] + " " + columns[3] + " " + columns[4] + " " + columns[5] + " " + columns[6] + " " + columns[7]);

    var insertQuery = "INSERT INTO Card (DeckID, CardName, ImageFilePath, StatOne, StatTwo, StatThree, StatFour, StatFive, StatSix) VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

    SqlCommand command = new SqlCommand(insertQuery, cnn);
    adapter.InsertCommand = new SqlCommand(insertQuery, cnn);
    command.Parameters.AddWithValue("@p0", columns[0]);
    command.Parameters.AddWithValue("@p1", columns[1]);
    command.Parameters.AddWithValue("@p2", columns[2]);
    command.Parameters.AddWithValue("@p3", columns[3]);
    command.Parameters.AddWithValue("@p4", columns[4]);
    command.Parameters.AddWithValue("@p5", columns[5]);
    command.Parameters.AddWithValue("@p6", columns[6]);
    command.Parameters.AddWithValue("@p7", columns[7]);
    command.Parameters.AddWithValue("@p8", columns[8]);
   command.ExecuteNonQuery();

    command.Dispose();

    foreach (string column in columns)
    {
        
    }
}

// Response.Write("Connection MAde");
cnn.Close();
*/

app.Run();