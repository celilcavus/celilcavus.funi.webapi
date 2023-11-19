namespace Funi.Models;
public class Shop
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }

    public string Name { get; set; } = String.Empty;
    public bool IsActive { get; set; }
    public DateTime CreateAtDate { get; set; }
    public DateTime UpdateAtDate { get; set; }

    public Shop()
    {
        IsActive = true;
        CreateAtDate = DateTime.Now;
        UpdateAtDate = DateTime.Now;
    }
}