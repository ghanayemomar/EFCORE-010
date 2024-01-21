using EFCORE_10.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id); // set primary key;
            //
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.CourseName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.ToTable("Courses");
            //
            builder.Property(x => x.Price).HasPrecision(15, 2);
            //
        }
    }
}
