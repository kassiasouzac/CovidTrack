using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class LocalAtendimentoMap : IEntityTypeConfiguration<LocalAtendimento>
    {
        public void Configure(EntityTypeBuilder<LocalAtendimento> builder)
        {
            builder.HasKey(la => la.LocalAtendimentoId);

            builder.Property(la => la.NomeLocal).IsRequired().HasMaxLength(50);

            builder.HasOne(la => la.Localizacao).WithMany(la => la.LocalAtendimentos).HasForeignKey(la => la.LocalizacaoId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("LocaisAtendimentos");
        }
    }
}
