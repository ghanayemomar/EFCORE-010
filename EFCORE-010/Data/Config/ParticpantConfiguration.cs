using EFCORE_010.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_10.Data.Config
{
    public class ParticpantConfiguration : IEntityTypeConfiguration<Particpant>
    {
        public void Configure(EntityTypeBuilder<Particpant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            //
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            //
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            //
            builder.HasDiscriminator<string>("ParricipantType").HasValue<Individaul>("INDV").HasValue<Coporate>("COPR");
            //
            builder.Property("ParricipantType").HasColumnType("VARCHAR").HasMaxLength(4);
            //
            builder.ToTable(nameof(Particpant));
            //
        }
    }

}
