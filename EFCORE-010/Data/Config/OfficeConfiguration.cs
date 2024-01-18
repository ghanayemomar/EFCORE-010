using EFCORE_10.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);
            //
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.OfficeName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            //
            builder.Property(x => x.OfficeLocation).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            //
            builder.ToTable("Offices");
            //
            builder.HasData(LoadOffices());
            //
        }

        private static List<Office> LoadOffices()
        {
            return new List<Office>
            {
                new Office {Id = 1, OfficeName = "Off-05", OfficeLocation = "building A" },
                new Office {Id = 2, OfficeName = "Off-06", OfficeLocation = "building B" },
                new Office {Id = 3, OfficeName = "Off-07", OfficeLocation = "Adminstration"},
                new Office {Id = 4, OfficeName = "Off-08", OfficeLocation = "IT Department"},
                new Office {Id = 5, OfficeName = "Off-09", OfficeLocation = "IT Department"},
            };
        }
    }
}
