namespace Funi.Models;

public class Contact : BaseModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAdress { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}