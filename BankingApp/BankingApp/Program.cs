// See https://aka.ms/new-console-template for more information
using BankingApp.Models;
using System.Net.Http.Headers;

Customer.BankName = "SBI";
//upcasting
Customer customer = new Individual(Faker.RandomNumber.Next(10000, 1000000), new FullName
{
    FirstName = Faker.Name.First(),
    LastName = Faker.Name.Last(),
    MiddleName = Faker.Name.Middle(),
});


//downcasting
Individual individual= customer as Individual;

