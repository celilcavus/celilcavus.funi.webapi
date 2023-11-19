namespace Funi.Models;

public class Communication : BaseModel
{
    public string Location { get; set; } = string.Empty;
    public string EmailAdress { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}