using EFCORE_010.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            //
            builder.ToTable("Students");
            //
        }
    }

}
