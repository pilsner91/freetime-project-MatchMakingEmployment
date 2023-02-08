namespace Domain.Domain.Entities;

public class Company : IUser
{
    private string Name { get; set; }

    public Company(string name)
    {
        Name = name;
    }
}