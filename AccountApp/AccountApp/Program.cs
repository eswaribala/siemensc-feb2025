// See https://aka.ms/new-console-template for more information

using AccountApp.Models;
using AccountApp.Repositories;
using Newtonsoft.Json;
using System.Collections;
using System.Net.Http.Headers;

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

Console.ReadKey();