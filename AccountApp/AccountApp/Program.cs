// See https://aka.ms/new-console-template for more information

using AccountApp.Models;
using System.Collections;

DirectDebit directDebit;
BitArray bitArray=new BitArray(10);

for (int i = 0; i < 10; i++)
{
    directDebit = new DirectDebit();

    directDebit.Amount = Faker.RandomNumber.Next(1000, 100000);
    if(directDebit.Amount <5000)
     bitArray[i] = false;
    else 
     bitArray[i] = true;

}

IEnumerator enumerator=bitArray.GetEnumerator();
while (enumerator.MoveNext())
{
    if (bool.Parse(enumerator.Current.ToString()) == true)
        Console.WriteLine("Transaction Successful");
    else
        Console.WriteLine("Transaction UnSuccessful");
}

Console.ReadKey();