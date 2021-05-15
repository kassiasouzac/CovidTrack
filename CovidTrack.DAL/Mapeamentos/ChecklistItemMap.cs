using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class ChecklistItemMap : IEntityTypeConfiguration<ChecklistItem>
    {
        public void Configure(EntityTypeBuilder<ChecklistItem> builder)
        {
            builder.HasKey(q => q.ItemId);

            builder.Property(q => q.Conteudo).IsRequired().HasMaxLength(200);

            builder.HasMany(q => q.Checklists).WithOne(q => q.ChecklistItem);

            builder.ToTable("Itens");
        }
    }
}
