// See https://aka.ms/new-console-template for more information
using BankingApp.Contexts;
using BankingApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

var configuration=new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var services=new ServiceCollection();
services.AddDbContext<BankingContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("DefaultConn")));
var provider=services.BuildServiceProvider();
var context = provider.GetRequiredService<BankingContext>();

Console.WriteLine("Database Connection Established...");

Console.ReadKey();







Console.ReadKey();