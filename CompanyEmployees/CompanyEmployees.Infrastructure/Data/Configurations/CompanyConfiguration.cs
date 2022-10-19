using CompanyEmployees.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyEmployees.Infrastructure.Data.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> company)
    {
        company.Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired();

        company.Property(c => c.Address)
               .HasMaxLength(500)
               .IsRequired();

        company.Property(c => c.Country)
               .HasMaxLength(100)
               .IsRequired();
    }
}
