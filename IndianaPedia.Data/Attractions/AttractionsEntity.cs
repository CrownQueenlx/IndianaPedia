using System.ComponentModel.DataAnnotations;

namespace IndianaPedia.Data;

public class AttractionsEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int Rating { get; set; }
    public double Cost { get; set; }
}