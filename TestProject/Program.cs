//This is introductory C#
/*
 * Author : Parameswari
 * Date: 24-02-2025
 */
//read your name and dob
//calculate age
//variables

using TestProject;

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
Console.ReadKey();
