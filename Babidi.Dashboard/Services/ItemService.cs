using Babidi.Dashboard.Models;

namespace Babidi.Dashboard.Services;

public class ItemService
{
    private readonly List<DashboardItem> _items =
    [
        new() { Id = 1, Name = "Starter Item", Category = "General", Status = "Active", CreatedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-7)), Value = 1000, IsFeatured = true },
        new() { Id = 2, Name = "Pipeline Item", Category = "Sales", Status = "Pending", CreatedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-5)), Value = 2300 },
        new() { Id = 3, Name = "Archived Item", Category = "Ops", Status = "Archived", CreatedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-3)), Value = 300 }
    ];

    public IReadOnlyList<DashboardItem> GetAll(string? query = null)
    {
        var items = _items.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(query))
        {
            items = items.Where(x => x.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || x.Category.Contains(query, StringComparison.OrdinalIgnoreCase));
        }

        return items.OrderBy(x => x.Id).ToList();
    }

    public DashboardItem? GetById(int id) => _items.FirstOrDefault(x => x.Id == id);

    public void Save(DashboardItem item)
    {
        var existing = GetById(item.Id);
        if (existing is null)
        {
            item.Id = _items.Count == 0 ? 1 : _items.Max(x => x.Id) + 1;
            item.CreatedDate = DateOnly.FromDateTime(DateTime.Today);
            _items.Add(item);
            return;
        }

        existing.Name = item.Name;
        existing.Category = item.Category;
        existing.Status = item.Status;
        existing.Value = item.Value;
        existing.IsFeatured = item.IsFeatured;
        existing.Notes = item.Notes;
    }
}
