using System.ComponentModel.DataAnnotations;

namespace Mvc.Models;

public class Demoabc
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Score { get; set; }
}
