namespace MyProject.Domain.Entities;

using MyProject.Domain.Common;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int NationalCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}