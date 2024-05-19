using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBConfig
{
    public class EmployeeIdentityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                 .ToTable("Employee", SchemaNames.HR)
                 .HasIndex(e => e.FirstName)
                 .HasDatabaseName("IX_Employees_FirstName");

            builder.
                HasIndex(e => e.LastName)
                .HasDatabaseName("IX_Employees_LastName");
        }
    }
}
