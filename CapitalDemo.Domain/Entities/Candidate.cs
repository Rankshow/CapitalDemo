namespace CapitalDemo.Domain.Models;

public class Candidate : Common
{
    public string FirstName { get; set; }   
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Nationality { get; set; }
    public string CurrentResidence { get; set; }
    public double IDNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Gender {  get; set; }
    public ICollection<Employer> Employers { get; set; }
}
