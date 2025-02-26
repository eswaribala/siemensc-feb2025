// See https://aka.ms/new-console-template for more information
using BankingApp.Contexts;
using BankingApp.Models;
using BankingApp.Repository;
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

Console.WriteLine("\nCreating a new Customer...");
var newCustomer = new Customer
{

    Email = Faker.Internet.Email(),
    FullName = new FullName
    {
        FirstName = Faker.Name.First(),
        LastName = Faker.Name.Last(),
        MiddleName = Faker.Name.Middle()
    },
    Password = Faker.Identification.UkPassportNumber(),
    PhoneNumber = Faker.RandomNumber.Next(9000000000, 999999999)

};

ICustomerRepository customerRepository=new CustomerRepository(context);
//Customer responseCustomer=customerRepository.AddCustomer(newCustomer);

//Console.WriteLine($"Created Customer: Id = {responseCustomer.AccountNo}, Name = {responseCustomer.FullName.FirstName}");
//read all customers
customerRepository.GetAllCustomers().ForEach(customer => 
Console.WriteLine($"{customer.AccountNo},{customer.FullName.FirstName}"));


Console.ReadKey();