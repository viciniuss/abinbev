using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Configurations
{
    public class SaleItemEventConfiguration : IEntityTypeConfiguration<SaleItemEvent>
    {
        public void Configure(EntityTypeBuilder<SaleItemEvent> builder)
        {
            builder.HasKey(sie => sie.Id);

            builder.Property(sie => sie.SaleItemId)
                .IsRequired();

            builder.Property(sie => sie.EventType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(sie => sie.EventDate)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(sie => sie.EventData)
                .IsRequired()
                .HasColumnType("jsonb");
        }
    }
}
