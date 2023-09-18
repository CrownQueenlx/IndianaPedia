using System.ComponentModel.DataAnnotations;
using IndianaPedia.Enum;

namespace IndianaPedia.Models;

public class Attractions 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int Rating { get; set; }
    public double Cost { get; set; }
    public virtual TypeId {};
}