namespace Funi.Models;

public class OurTeam : BaseModel
{
    public string Image { get; set; } = String.Empty;
    public string Name { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public Title? Title { get; set; }
    public string title { get; set; } = string.Empty;
    public string Description { get; set; } = String.Empty;

    public string GetFullName()
    {
        return String.Concat(Name, " ", LastName);
    }
}

public class Title : BaseModel
{
    public string WorkerTitle { get; set; } = String.Empty;
}