using EFCORE_010.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EFCORE_10.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id); // set primary key;
            //
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.SectionName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.HasOne(x => x.Course).WithMany(x => x.Sections).HasForeignKey(x => x.CourseId).IsRequired();  // one to many scretion and course
            //
            builder.HasOne(x => x.Instructor).WithMany(x => x.Sections).HasForeignKey(x => x.InstructorId).IsRequired(false);
            //
            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(p => p.StarTime).HasColumnType("time");
                ts.Property(p => p.EndTime).HasColumnType("time");
            });
            //
            builder.HasOne(c => c.Schedule).WithMany(x => x.Sections).HasForeignKey(x => x.ScheduleId).IsRequired();
            //
            builder.HasMany(c => c.Particpant).WithMany(x => x.Sections).UsingEntity<Enrollment>();
            //
            builder.ToTable("Sections");
            //
        }
    }

}
