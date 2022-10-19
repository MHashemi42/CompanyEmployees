namespace CompanyEmployees.Core.Entities;

public class Employee : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public int CompanyId { get; set; }

    public Company Company { get; set; } = null!;
}
