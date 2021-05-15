using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class QuestionarioMap : IEntityTypeConfiguration<Questionario>
    {
        public void Configure(EntityTypeBuilder<Questionario> builder)
        {
            builder.HasKey(q => q.QuestionarioId);

            builder.Property(q => q.Resposta).IsRequired().HasMaxLength(10);

            builder.HasOne(q => q.Usuario).WithMany(q => q.Questionarios).HasForeignKey(q => q.UsuarioId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Questao).WithMany(q => q.Questionarios).HasForeignKey(q => q.QuestaoId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Questionarios");
        }
    }
}
