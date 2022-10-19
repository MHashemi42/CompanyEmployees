namespace CompanyEmployees.Core.Dtos.Company;

public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string FullAddress { get; set; } = null!;
}
