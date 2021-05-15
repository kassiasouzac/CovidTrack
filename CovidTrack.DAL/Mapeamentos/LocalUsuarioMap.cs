using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class LocalUsuarioMap : IEntityTypeConfiguration<LocalUsuario>
    {
        public void Configure(EntityTypeBuilder<LocalUsuario> builder)
        {
            builder.HasKey(lu => lu.LocalId);
            builder.Property(lu => lu.NomeLocal).IsRequired().HasMaxLength(50);

            builder.HasOne(lu => lu.Usuario).WithMany(lu => lu.LocalUsuarios).HasForeignKey(lu => lu.UsuarioId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(lu => lu.Localizacao).WithMany(lu => lu.LocalUsuarios).HasForeignKey(lu => lu.LocalizacaoId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("LocaisUsuarios");
        }
    }
}
