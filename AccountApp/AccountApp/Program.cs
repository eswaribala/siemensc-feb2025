// See https://aka.ms/new-console-template for more information

using AccountApp.Exceptions;
using AccountApp.Models;
using AccountApp.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Security.Principal;



/*
DirectDebit directDebit;
BitArray bitArray=new BitArray(10);

for (int i = 0; i < 10; i++)
{
    directDebit = new DirectDebit();
    Console.WriteLine(directDebit.GetHashCode());
    directDebit.Amount = Faker.RandomNumber.Next(1000, 100000);
    if(directDebit.Amount <5000)
     bitArray[i] = false;
    else 
     bitArray[i] = true;

}

IEnumerator enumerator=bitArray.GetEnumerator();
while (enumerator.MoveNext())
{
    string data = enumerator.Current.ToString();
    Console.WriteLine($"BitArray Value={data}");
    if (bool.Parse(data) == true)
        Console.WriteLine("Transaction Successful");
    else
        Console.WriteLine("Transaction UnSuccessful");
}
*/

//Stack
/*
StackDemo stackDemo=new StackDemo();
int decimalNo = Faker.RandomNumber.Next(1, 100);
Console.WriteLine($"Decimal Number={decimalNo}");
stackDemo.ConvertDecimalToBinary(decimalNo);
*/
/*
Transaction transaction=null;
Queue queue = new Queue();

for (int i = 0; i < 10; i++)
{
    transaction = new Transaction
    {
        Id = i,
        Amount=Faker.RandomNumber.Next(200, 10000),
        TimeStamp=DateTime.Now.ToLocalTime().ToString(),
        Sender=Faker.Name.FullName(),
        Receiver=Faker.Name.FullName()

    };
    queue.Enqueue(transaction);   

}

while(queue.Count > 0)
{
   Transaction transactionObj= (Transaction)queue.Dequeue();
    Console.WriteLine($"{transactionObj.Id},{ transactionObj.Amount} ");
    Thread.Sleep(2000);
    Console.WriteLine("Transaction in Process...");

}

Console.WriteLine("All the transactions done...");

*/

//List Demo
/*
ITransactionRepository transactionRepository = new TransactionRepository();
AccountApp.Models.Transaction transaction = null;
for(int i = 0; i < 100; i++)
{
    transaction = new Transaction
    {
        Id = i,
        Amount = Faker.RandomNumber.Next(200, 10000),
        TimeStamp = DateTime.Now.ToLocalTime().ToString(),
        Sender = Faker.Name.FullName(),
        Receiver = Faker.Name.FullName()

    };
    transactionRepository.AddTransaction(transaction);
}

//Retrieve all transactions
transactionRepository.GetTransactions().ForEach(transaction =>
{
    Console.WriteLine(JsonConvert.SerializeObject(transaction));
}

);

//Retrieve Specific Object
Console.WriteLine("Get Transaction By Transaction Id.....");

Console.WriteLine(JsonConvert.SerializeObject(transactionRepository
    .GetTransactionById(Faker.RandomNumber.Next(0, 100)),Formatting.Indented));


//Delete the object
long id = Faker.RandomNumber.Next(0, 100);
Console.WriteLine($"Delete Transaction By Transaction Id.....{id}");

if (transactionRepository.DeleteTransaction(id))
    Console.WriteLine("Transaction Deleted.....");
else
    Console.WriteLine("Transaction Not Deleted.....");


//Sorted Transaction
transactionRepository.GetSortedTransactions().ForEach(transaction =>
{
    Console.WriteLine(JsonConvert.SerializeObject(transaction));
}

);
*/
double mantissa = (new Random().NextDouble() * 2.0) - 1.0;
// choose -149 instead of -126 to also generate subnormal floats (*)
double exponent = Math.Pow(2.0, new Random().Next(-126, 128));
/*


Account account = null;
IAccountRepository accountRepository = new AccountRepository();
for (int i = 0; i < 10; i++)
{

     account= new SavingsAccount
    {
        AccountId=i, 
        RunningTotal = Faker.RandomNumber.Next(5000, 5000000),
        RateOfInterest = (float)(mantissa * exponent),
        DOP = Faker.Identification.DateOfBirth()

    };

    ITransactionRepository transactionRepository = new TransactionRepository();
    AccountApp.Models.Transaction transaction = null;
    for (int j = 0; j < Faker.RandomNumber.Next(3,20); j++)
    {
        transaction = new Transaction
        {
            Id = j,
            Amount = Faker.RandomNumber.Next(200, 10000),
            TimeStamp = DateTime.Now.ToLocalTime().ToString(),
            Sender = Faker.Name.FullName(),
            Receiver = Faker.Name.FullName()

        };
        transactionRepository.AddTransaction(transaction);
    }
//sorted list
    accountRepository.AddAccount(account, transactionRepository.GetTransactions());


}


//show account and list of transactions as statement

foreach(KeyValuePair<Account,List<Transaction>> keyValuePair in accountRepository.GetAllTransactions()){
   
    Console.WriteLine(JsonConvert.SerializeObject(keyValuePair.Key, Formatting.Indented));
   
    keyValuePair.Value.ForEach(transaction =>
    {
        Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));
    });
}
*/

Account account = null;

try
{
   account = new SavingsAccount
    {
        AccountId = -12,
        RunningTotal = Faker.RandomNumber.Next(5000, 10000),
        RateOfInterest = (float)(mantissa * exponent),
        DOP = Faker.Identification.DateOfBirth()
        //c# extension method



};
    Console.WriteLine(account.IsRunningTotalBelowMinimum());
}
catch(AccountIdException exception)
{
    Console.WriteLine(exception.Message);
}


string text = "Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index";

Console.WriteLine(text.WordCount());

Console.ReadKey();