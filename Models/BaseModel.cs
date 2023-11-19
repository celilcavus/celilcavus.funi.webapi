namespace Funi.Models;

public class BaseModel
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreateAtDate { get; set; }
    public DateTime UpdateAtDate { get; set; }

    public BaseModel()
    {
        IsActive = true;
        CreateAtDate = DateTime.Now;
        UpdateAtDate = DateTime.Now;
    }
}