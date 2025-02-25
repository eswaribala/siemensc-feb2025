// See https://aka.ms/new-console-template for more information
using BankingApp.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

var configuration=new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();








//create 100 individuals sort them based dob
Individual[] individuals=new Individual[100];

Gender gender;
for(int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
      gender = Gender.MALE;
    else
        gender = Gender.FEMALE;

    individuals[i] = new Individual(Faker.RandomNumber.Next(1000, 100000),
        new FullName
        {
            FirstName = Faker.Name.First(),
            LastName = Faker.Name.Last(),
            MiddleName = Faker.Name.Middle(),
        });
    individuals[i].DOB = Faker.Identification.DateOfBirth();
    individuals[i].Gender = gender;
    individuals[i].SetValues(Faker.Internet.Email(), Faker.Identification.UsPassportNumber(),
        Faker.RandomNumber.Next(90000000000,999999999),new Address
        {
            DoorNo=Faker.Address.SecondaryAddress(),
            StreetName=Faker.Address.StreetName(),
            City=Faker.Address.City(),
            Region=Faker.Address.CaProvince(),
            Country=Faker.Address.Country(),
            PostalCode=Faker.Address.ZipCode(),
        });


   
}
Array.Sort(individuals);

individuals.ToList().ForEach(x => Console.WriteLine(x));

Console.ReadKey();