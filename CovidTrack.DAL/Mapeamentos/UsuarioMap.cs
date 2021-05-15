using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Id AUTOINCREMENT
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.HasIndex(u => u.Id).IsUnique();

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(30);

            builder.Property(u => u.Sobrenome).IsRequired().HasMaxLength(100);

            builder.Property(u => u.DataDeNascimento).IsRequired().HasMaxLength(10);

            builder.HasMany(u => u.Checklists).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Questionarios).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Vacinacoes).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.LocalUsuarios).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Notificacoes).WithOne(u => u.Usuario).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Usuarios");

        }
    }
}
