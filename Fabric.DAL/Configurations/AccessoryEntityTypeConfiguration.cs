using Fabric.DAL.Abstractions.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fabric.DAL.Configurations;

internal class AccessoryEntityTypeConfiguration : IEntityTypeConfiguration<Accessory>
{
    public void Configure(EntityTypeBuilder<Accessory> builder)
    {
        builder.HasKey(x => x.Id);
        
    }
}