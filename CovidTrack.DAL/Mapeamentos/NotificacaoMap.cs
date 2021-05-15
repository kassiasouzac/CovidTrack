using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class NotificacaoMap : IEntityTypeConfiguration<Notificacao>
    {
        public void Configure(EntityTypeBuilder<Notificacao> builder)
        {
            builder.HasKey(n => n.NotificacaoId);

            builder.Property(n => n.DataSegundaDose).IsRequired().HasMaxLength(10);

            builder.Property(n => n.Status).IsRequired().HasMaxLength(2);

            builder.HasOne(n => n.Usuario).WithMany(n => n.Notificacoes).HasForeignKey(n => n.UsuarioId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(n => n.Vacinacao).WithMany(n => n.Notificacoes).HasForeignKey(n => n.VacinacaoId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Notificacoes");
        }
    }
}
