// See https://aka.ms/new-console-template for more information
using BankingApp.Models;

Customer customer = new Customer();
customer.AccountNo = Faker.RandomNumber.Next(1, 1000000);
customer.Email = Faker.Internet.Email();
customer.FullName = new FullName
{
    FirstName = Faker.Name.First(),
    LastName = Faker.Name.Last(),
    MiddleName = Faker.Name.Middle(),

};
customer.Address = new Address
{
    StreetName = Faker.Address.StreetName(),
    City = Faker.Address.City(),
    Country = Faker.Address.Country(),
    PostalCode = Faker.Address.UkPostCode(),
    DoorNo = Faker.Address.SecondaryAddress(),
    Region = Faker.Address.CaProvince()

};
customer.PhoneNumber = Faker.RandomNumber.Next(9000000000, 9999999999);
customer.Password=Faker.Identification.UsPassportNumber();

//getter

Console.WriteLine($"AccountNo={customer.AccountNo}" +
    $"Email={customer.Email},PhoneNo={customer.PhoneNumber}");
Console.ReadKey();
