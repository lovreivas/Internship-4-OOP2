using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;

namespace UsersApp.infrastructure.Database.Configurations.Companies
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>

    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id");

            builder.Property(c => c.Name).HasColumnName("name");




        }
    }
}
