using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class CategoriaComorbidadeMap : IEntityTypeConfiguration<CategoriaComorbidade>
    {
        public void Configure(EntityTypeBuilder<CategoriaComorbidade> builder)
        {
            builder.HasKey(cm => cm.ComorbidadeId);
            builder.Property(cm => cm.Descricao).IsRequired().HasMaxLength(80);

            builder.HasMany(cm => cm.Usuarios).WithOne(cm => cm.CategoriaComorbidade).OnDelete(DeleteBehavior.NoAction);
            
            builder.HasData(
                new CategoriaComorbidade
                {
                    ComorbidadeId = 1,
                    Descricao = "Diabetes Melitus"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 2,
                    Descricao = "Pneumopatias crônicas graves"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 3,
                    Descricao = "Hipertensão arterial resistente (HAR)"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 4,
                    Descricao = "Hipertensão arterial - estágio 3"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 5,
                    Descricao = "Hipertensão arterial - estágio 1 e 2, com LOA ou comorbidade"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 6,
                    Descricao = "Insuficiência cardíaca"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 7,
                    Descricao = "Cor-pulmonale e Hipertensão pulmonar"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 8,
                    Descricao = "Cardiopatia Hipertensiva"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 9,
                    Descricao = "Síndromes coronarianas"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 10,
                    Descricao = "Valvopatias"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 11,
                    Descricao = "Miocardiopatias e pericardiopatias"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 12,
                    Descricao = "Doenças da Aorta, dos grandes vasos e fístulas arteriovenosas"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 13,
                    Descricao = "Arritmias cardíacas"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 14,
                    Descricao = "Cardiopatia congênita no adulto"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 15,
                    Descricao = "Próteses valvares e dispositivos cardíacos"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 16,
                    Descricao = "Doença cerebrovascular"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 17,
                    Descricao = "Doença renal crônica"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 18,
                    Descricao = "Imunossuprimidos"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 19,
                    Descricao = "Anemia falciforme"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 20,
                    Descricao = "Obesidade mórbida"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 21,
                    Descricao = "Sindrome de Down"
                },
                new CategoriaComorbidade
                {
                    ComorbidadeId = 22,
                    Descricao = "Cirrose hepática"
                }
                );
            builder.ToTable("Categorias");
        }
    }
}
