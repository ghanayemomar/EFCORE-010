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
            builder.HasData(LoadInstructors());

        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor {Id = 1, Name = "Omar Ghanayem" , OfficeId=1},
                new Instructor {Id = 2, Name = "Amr Shadid", OfficeId=2},
                new Instructor {Id = 3, Name = "Abood Mukhemar",OfficeId=3},
                new Instructor {Id = 4, Name = "Abood Saleh", OfficeId = 4},
                new Instructor {Id = 5, Name = "Hamood Khamalan", OfficeId = 5},
            };
        }
    }

}
