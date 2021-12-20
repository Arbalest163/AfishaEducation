using Afisha.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afisha.Persistence.EntityTypeConfigurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("events");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id).IsUnique();
            builder.Property(e => e.Title).HasMaxLength(20).IsRequired();
            builder.Property(e => e.Country).HasMaxLength(30).HasDefaultValue("РФ");
            builder.Property(e => e.City).HasMaxLength(30).HasDefaultValue("Самара");
            builder.Property(e => e.Place).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Description).HasColumnType("text");
            builder.Property(e => e.MaxCountTicket).HasColumnType("smallint").IsRequired();
            builder.Property(e => e.CountTicketSold).HasColumnType("smallint");
            builder.Property(e => e.AgeRestriction).HasColumnType("tinyint").HasDefaultValue("12");
            builder.Property(e => e.DateStart).HasColumnType("date").IsRequired();
            builder.Property(e => e.DateEnd).HasColumnType("date");
            //builder.Property(e => e.TimeEvent).HasColumnType("time");
        }
    }
}
