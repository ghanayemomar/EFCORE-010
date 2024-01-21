using EFCORE_010.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_010.Data.Config
{
    public class IndividualConfiguration : IEntityTypeConfiguration<Individaul>
    {
        public void Configure(EntityTypeBuilder<Individaul> builder)
        {
            builder.ToTable("Individauls");
        }
    }
}
