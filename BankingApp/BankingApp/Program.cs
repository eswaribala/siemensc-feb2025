// See https://aka.ms/new-console-template for more information
using BankingApp.Models;
using System.Net.Http.Headers;

Customer.BankName = "SBI";



Customer customer = new Customer(Faker.RandomNumber.Next(1, 1000000), new FullName
{
    FirstName = Faker.Name.First(),
    LastName = Faker.Name.Last(),
    MiddleName = Faker.Name.Middle(),

});

customer.Email = Faker.Internet.Email();

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
    $"Email={customer.Email},PhoneNo={customer.PhoneNumber} created for the Bank {Customer.BankName}");



//struct

Transaction transaction = new Transaction(Faker.RandomNumber.Next(1, 1000000));

transaction.Amount = Faker.RandomNumber.Next(1, 1000000);

Console.WriteLine($"{transaction.TransactionId},{transaction.Amount}, {Transaction.ROI}");
Console.ReadKey();