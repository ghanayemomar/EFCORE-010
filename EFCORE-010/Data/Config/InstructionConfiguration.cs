using EFCORE_10.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class InstructionConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            //
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.HasOne(x => x.Office).WithOne(x => x.Instructor).HasForeignKey<Instructor>(x => x.OfficeId).IsRequired(false);
            //
            builder.ToTable("Instructors");
            //
        }

    
    }

}
