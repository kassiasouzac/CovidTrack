﻿
using CovidTrack.BLL.Models;
using CovidTrack.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrack.DAL.Repositorios
{
    public class FuncaoRepositorio : RepositorioGenerico<Funcao>, IFuncaoRepositorio
    {
        private readonly Contexto _contexto;
        private readonly RoleManager<Funcao> _gerenciadorFuncoes;

        public FuncaoRepositorio(Contexto contexto, RoleManager<Funcao> gerenciadorFuncoes) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorFuncoes = gerenciadorFuncoes;
        }

        public async Task AdicionarFuncao(Funcao funcao)
        {
            try
            {
                await _gerenciadorFuncoes.CreateAsync(funcao);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task AtualizarFuncao(Funcao funcao)
        {
            try
            {
                Funcao f = await PegarPeloId(funcao.Id);
                f.Name = funcao.Name;
                f.NormalizedName = funcao.NormalizedName;
                f.Descricao = funcao.Descricao;

                await _gerenciadorFuncoes.UpdateAsync(f);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
