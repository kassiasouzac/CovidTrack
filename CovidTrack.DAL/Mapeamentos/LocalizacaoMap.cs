using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class LocalizacaoMap : IEntityTypeConfiguration<Localizacao>
    {
        public void Configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder.HasKey(l => l.LocalizacaoId);

            builder.Property(l => l.Latidude).IsRequired().HasMaxLength(12);
            builder.Property(l => l.Longitude).IsRequired().HasMaxLength(13);

            builder.HasMany(l => l.LocalAtendimentos).WithOne(l => l.Localizacao).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(l => l.LocalUsuarios).WithOne(l => l.Localizacao).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Localizacoes");
        }
    }
}
