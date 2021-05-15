using CovidTrack.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL.Mapeamentos
{
    public class ChecklistMap : IEntityTypeConfiguration<Checklist>
    {
        public void Configure(EntityTypeBuilder<Checklist> builder)
        {
            builder.HasKey(ck => ck.ChecklistId);

            builder.Property(ck => ck.IsCheck).IsRequired().HasMaxLength(2);


            builder.HasOne(ck => ck.Usuario).WithMany(ck => ck.Checklists).HasForeignKey(ck => ck.UsuarioId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ck => ck.ChecklistItem).WithMany(ck => ck.Checklists).HasForeignKey(ck => ck.ItemId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Checklists");
        }
    }
}
