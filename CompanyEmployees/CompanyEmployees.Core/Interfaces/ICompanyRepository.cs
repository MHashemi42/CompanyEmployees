using CompanyEmployees.Core.Entities;
using CompanyEmployees.Core.Models;
using CompanyEmployees.Core.Models.Parameters;

namespace CompanyEmployees.Core.Interfaces;

public interface ICompanyRepository
{
    Task<PagedList<Company>> GetCompaniesAsync(CompanyParameters companyParameters);
}
