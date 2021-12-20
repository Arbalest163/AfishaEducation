using Afisha.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afisha.Persistence.EntityTypeConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("clients");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id).IsUnique();
            builder.Property(c => c.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(20).IsRequired();
            builder.Property(c => c.MiddleName).HasMaxLength(20);
            builder.Property(c => c.Birthday).IsRequired();
            builder.Property(c => c.Birthday).HasColumnType("date");

            builder.HasMany(c => c.Tickets).WithMany(c => c.Client);
        }

    }
}
