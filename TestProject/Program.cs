//This is introductory C#
/*
 * Author : Parameswari
 * Date: 24-02-2025
 */
//read your name and dob
//calculate age
//variables

using TestProject;
//verbatim
string testData=@"
      112, First Street
      Dr.Parakasam Nagar
      Chennai - 602024
    ";

Console.WriteLine(testData);
string[] users = new string[10];

for (int i = 0; i < users.Length; i++)
    users[i] = Faker.Name.FullName();

int[] numbers=new int[10];
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = Faker.RandomNumber.Next(100, 1000);

numbers.ToList().ForEach(x => Console.WriteLine(x));
int data = 100;
//read only variable
InDemo.ShowData(in data);

Console.WriteLine("Enter Search Element");
int searchElement = int.Parse(Console.ReadLine());

Console.WriteLine($"Found the element in array={RefDemo.ProcessData(ref numbers,searchElement)}");

//boxing and unboxing

int age = 55; //value type --> stack
//primitive to object 
object obj = age; //---> refrence type heap 
Console.WriteLine(obj);

//unboxing
//object to primitive
age = (int)obj;

//int to long

int employeeId = Faker.RandomNumber.Next(10000, 1000000);

//int to long
long employeeNo = Convert.ToInt64(employeeId);




//display 10 users

//foreach (var user in users)
//   Console.WriteLine(user);

//LINQ
//users.ToList().ForEach(x => Console.WriteLine(x));

//Jagged Array
/*
Console.WriteLine("Enter no of customers");
int rows=int.Parse(Console.ReadLine());
int[][] emiArray=new int[rows][];

for (int i = 0;i < rows; i++)
{
    Console.WriteLine($"Enter no of emis for customer{i}");
    int cols = int.Parse(Console.ReadLine());
    emiArray[i]=new int[cols];
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"Enter  emis amount for EMI{j}");
        emiArray[i][j] = int.Parse(Console.ReadLine());
    }

}

for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < emiArray[i].Length; j++)
    {
        Console.Write($"{emiArray[i][j]},");
    }
    Console.WriteLine("\n");
}


*/



/*
Console.WriteLine("Enter Name");
string name=Console.ReadLine();
Console.WriteLine("Enter DOB(YYYY-MM-DD)");
string dob=Console.ReadLine();
DateTime birthDate=DateTime.Parse(dob);
int age=DateTime.Now.Year-birthDate.Year;
Console.WriteLine($"Name={name}");
Console.WriteLine($"Calculated Age={age} years");
Console.WriteLine("Enter Gender(MALE,FEMALE,TRANSGENDER)");
string gender = Console.ReadLine();
Gender genderData,genderResponse;
//String to Enum
if (Enum.TryParse(gender, true, out genderResponse)) { 
    genderData = genderResponse;
    Console.WriteLine($"Gender={genderData}");
    }else
    {
    Console.WriteLine("Could Not be Parsed");
    }
*/
Console.ReadKey();
