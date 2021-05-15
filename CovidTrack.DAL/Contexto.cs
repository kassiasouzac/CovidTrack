using CovidTrack.BLL.Models;
using CovidTrack.DAL.Mapeamentos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTrack.DAL
{
    public class Contexto : IdentityDbContext<Usuario, Funcao, string>
    {
        public DbSet<CategoriaComorbidade> Comorbidades { get; set; }

        public DbSet<Checklist> Checklists { get; set; }

        public DbSet<ChecklistItem> Itens { get; set; }

        public DbSet<Funcao> Funcoes { get; set; }

        public DbSet<LocalAtendimento> LocaisAtendimentos { get; set; }

        public DbSet<LocalUsuario> LocaisUsuarios { get; set; }

        public DbSet<Localizacao> Localizacoes { get; set; }

        public DbSet<Notificacao> Notificacoes { get; set; }

        public DbSet<Questao> Questoes { get; set; }

        public DbSet<Questionario> Questionarios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Vacinacao> Vacinacoes { get; set; }

        public Contexto(DbContextOptions<Contexto> Opcoes) : base(Opcoes) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategoriaComorbidadeMap());
            builder.ApplyConfiguration(new ChecklistItemMap());
            builder.ApplyConfiguration(new ChecklistMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new LocalAtendimentoMap());
            builder.ApplyConfiguration(new LocalUsuarioMap());
            builder.ApplyConfiguration(new LocalizacaoMap());
            builder.ApplyConfiguration(new NotificacaoMap());
            builder.ApplyConfiguration(new QuestaoMap());
            builder.ApplyConfiguration(new QuestionarioMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VacinacaoMap());
        }
    }
}
