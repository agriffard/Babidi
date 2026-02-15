using System.ComponentModel.DataAnnotations;

namespace Babidi.Dashboard.Models;

public class DashboardItem
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    public string Status { get; set; } = "Draft";

    public DateOnly CreatedDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    [Range(0, 1000000)]
    public decimal Value { get; set; }

    public bool IsFeatured { get; set; }

    public string Notes { get; set; } = string.Empty;
}
