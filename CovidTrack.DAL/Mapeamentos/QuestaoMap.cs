using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class QuestaoMap : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            builder.HasKey(q => q.QuestaoId);

            builder.Property(q => q.Pergunta).IsRequired().HasMaxLength(200);

            builder.HasMany(q => q.Questionarios).WithOne(q => q.Questao);

            builder.ToTable("Questoes");
        }
    }
}
