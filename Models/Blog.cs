namespace Funi.Models;

public class Blog : BaseModel
{
    public string Image { get; set; } = "";
    public String Title { get; set; } = String.Empty;

    public string Description { get; set; } = "";
    public OurTeam? Team { get; set; }
}