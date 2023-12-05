namespace Learning.Management.System.Data.Model;

public abstract class ContactInfoBase : IContactInfo
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string TelephoneNumber { get; set; }
}