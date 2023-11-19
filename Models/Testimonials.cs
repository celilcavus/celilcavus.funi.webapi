namespace Funi.Models;

public class Testimonials:BaseModel
{
    public string Comments { get; set; } = String.Empty;
    public OurTeam? Team { get; set; }
    
}