using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class VacinacaoMap : IEntityTypeConfiguration<Vacinacao>
    {
        public void Configure(EntityTypeBuilder<Vacinacao> builder)
        {
            builder.HasKey(v => v.VacinacaoId);

            builder.Property(v => v.VacinaStatus).IsRequired().HasMaxLength(2);

            builder.Property(v => v.DataVacinacao).IsRequired().HasMaxLength(10);

            builder.Property(v => v.Marca).IsRequired().HasMaxLength(20);

            builder.HasOne(v => v.Usuario).WithMany(v => v.Vacinacoes).HasForeignKey(v => v.UsuarioId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(v => v.Notificacoes).WithOne(v => v.Vacinacao).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Vacinacoes");
        }
    }
}
