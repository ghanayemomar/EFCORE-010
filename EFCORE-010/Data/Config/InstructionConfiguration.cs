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
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.ToTable("Instructors");
            //
            builder.HasData(LoadInstructors());

        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor {Id = 1, Name = "Omar Ghanayem"},
                new Instructor {Id = 2, Name = "Amr Shadid"},
                new Instructor {Id = 3, Name = "Abood Mukhemar"},
                new Instructor {Id = 4, Name = "Abood Saleh"},
                new Instructor {Id = 5, Name = "Hamood Khamalan"},
            };
        }
    }
}
