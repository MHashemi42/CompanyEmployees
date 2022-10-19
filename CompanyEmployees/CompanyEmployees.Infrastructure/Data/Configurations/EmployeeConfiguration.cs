using CompanyEmployees.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyEmployees.Infrastructure.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> employee)
    {
        employee.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

        employee.Property(e => e.Position)
                .HasMaxLength(200)
                .IsRequired();
    }
}