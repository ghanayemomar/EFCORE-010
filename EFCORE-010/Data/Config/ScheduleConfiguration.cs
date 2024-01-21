using EFCORE_010.Entites;
using EFCORE_010.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id); // set primary key;
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Title).HasConversion(x => x.ToString(), x => (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x));
            builder.ToTable("Schedules");

        }
    }


}
