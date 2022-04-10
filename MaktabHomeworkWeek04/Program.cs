using System.IO;
Console.WriteLine(" Enter an Integer : ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter First Name : ");
Console.WriteLine("Enter Last Name : ");
Console.WriteLine("Enter Id : ");
Console.WriteLine("Enter Height : ");
Console.WriteLine("Enter Weight : ");
Console.WriteLine("Enter Mobile : ");
Console.WriteLine("Enter Birth Date : ");
Console.WriteLine("Enter Father Name : ");
Console.WriteLine("Enter Address : ");
string? filePath = @"D:\tamrinFile\TamrinFile.txt";
using (var stream = new FileStream(filePath, FileMode.Truncate))
{
    using (var writer = new StreamWriter(stream))
    {
        writer.Write("");
    }
}
for (int i = 0; i < count; i++)
{
    string? aFirstName = Console.ReadLine();
    string? aLastName = Console.ReadLine();
    string? aId = Console.ReadLine();
    string? aHeight = Console.ReadLine();
    string? aWeight = Console.ReadLine();
    string? aMobile = Console.ReadLine();
    string? aBirthDate = Console.ReadLine();
    string? aFatherName = Console.ReadLine();
    string? aAddress = Console.ReadLine();
    Person person = new Person(aFirstName, aLastName, aId, aHeight, aWeight, aMobile, aBirthDate, aFatherName, aAddress);
    File.AppendAllText(filePath, person.FirstName + " - ");
    File.AppendAllText(filePath, person.LastName + " - ");
    File.AppendAllText(filePath, person.Id + " - ");
    File.AppendAllText(filePath, person.Height + " - ");
    File.AppendAllText(filePath, person.Weight + " - ");
    File.AppendAllText(filePath, person.Mobile + " - ");
    File.AppendAllText(filePath, person.BirthDate + " - ");
    File.AppendAllText(filePath, person.FatherName + " - ");
    File.AppendAllText(filePath, person.Address + "\n");
 }
Console.WriteLine("Do u want to see that info ? y/n");
Person person1 = new Person();
var check = Console.ReadLine();
var lines = File.ReadAllLines(filePath);
if (check == "y")
{
    var list = lines.Select(p => new Person()
    {
        FirstName = p.Split('-')[0].Trim(),
        LastName = p.Split('-')[1].Trim(),
        Id = p.Split('-')[2].Trim()
    }).ToList();
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    using (var stream = new FileStream(filePath, FileMode.Truncate))
    {
        using (var writer = new StreamWriter(stream))
        {
            writer.Write("");
        }
    }
}
else if (check == "n")
{
    using (var stream = new FileStream(filePath, FileMode.Truncate))
    {
        using (var writer = new StreamWriter(stream))
        {
            writer.Write("");
        }
    }
}
else
{
    Console.WriteLine("Invalid op");
    using (var stream = new FileStream(filePath, FileMode.Truncate))
    {
        using (var writer = new StreamWriter(stream))
        {
            writer.Write("");
        }
    }
}
