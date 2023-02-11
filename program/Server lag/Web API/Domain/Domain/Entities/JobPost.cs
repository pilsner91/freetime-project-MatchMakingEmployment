namespace Domain.Domain.Entities;

public class JobPost
{
    private int id;
    public string? Description { get; set; }
    public string Titel { get; private set; }
    private Company Owner { get; set; }

    public JobPost(string titel, string? description, Company owner)
    {
        this.Titel = titel;
        this.Description = description;
        Owner = owner;
    }
}