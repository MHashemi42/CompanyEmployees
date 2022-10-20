using CompanyEmployees.Core.Entities;
using CompanyEmployees.Core.Interfaces;
using CompanyEmployees.Core.Models;
using CompanyEmployees.Core.Models.Parameters;

namespace CompanyEmployees.Infrastructure.Data.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly AppDbContext _context;

    public CompanyRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<PagedList<Company>> GetCompaniesAsync(CompanyParameters companyParameters)
    {
        throw new NotImplementedException();
    }
}
