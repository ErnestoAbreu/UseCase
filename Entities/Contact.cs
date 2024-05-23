namespace UseCase.Entities;

public class Contact
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public Guid Owner { get; set; }
}