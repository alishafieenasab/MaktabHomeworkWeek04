public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Id { get; set; }
    public string? Height { get; set; }
    public string Weight { get; set; }
    public string? Mobile { get; set; }
    public string? BirthDate { get; set; }
    public string? FatherName { get; set; }
    public string? Address { get; set; }

    public Person(string firstName, string lastName, string id, string height, string weight, string mobile, string birthDate, string fatherName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Height = height;
        Weight = weight;
        Mobile = mobile;
        BirthDate = birthDate;
        FatherName = fatherName;
        Address = address;
        
    }
    public Person()
    {

    }
    public override string ToString()
    {
        return $"{FirstName} - {LastName} - {Id} ";
    }
}

