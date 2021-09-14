using System;
using System.Collections.Generic;
using System.Linq;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Entities.Campeao;
using Lol.Domain.Factories;
using Lol.Infra.Context;
using Lol.Infra.Models;

namespace Lol.Infra.Repositories
{
    public class CampeaoRepository : ICampeaoRepository
    {
        private LolContext _context;
        public CampeaoRepository(LolContext context)
        {
            this._context = context;
        }
        public void Adicionar(CampeaoEntity campeaoEntity)
        {
            try
            {
                var campeaoModel = CampeaoModelFactory.Build(campeaoEntity);
                this._context.Campeoes.Add(campeaoModel);
                this._context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível adicionar o campeão.");
            }
        }

        public void Atualizar(Guid id, CampeaoEntity campeaoEntity)
        {
            try
            {
                CampeaoModel campeaoAntigo = this._recuperarPorId(id);
                if (campeaoAntigo != null)
                {
                    campeaoAntigo.Nome = campeaoEntity.Nome.Valor;
                    campeaoAntigo.DanoFisico = campeaoEntity.DanoFisico;
                    campeaoAntigo.PoderDeHabilidade = campeaoEntity.PoderDeHabilidade;
                    campeaoAntigo.Armadura = campeaoEntity.Armadura;
                    campeaoAntigo.ResistenciaMagica = campeaoEntity.ResistenciaMagica;
                    campeaoAntigo.Vida = campeaoEntity.Vida;
                    campeaoAntigo.Lane = campeaoEntity.Lane.Valor;

                    this._context.Campeoes.Update(campeaoAntigo);
                    this._context.SaveChanges();
                }
            }
            catch (System.Exception)
            {    
                throw new Exception("Não foi possível atualizar o campeão.");
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                CampeaoModel campeaoModel = this._recuperarPorId(id);
                if (campeaoModel != null)
                {
                    this._context.Remove(campeaoModel);
                    this._context.SaveChanges();
                }
                 
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível excluir o campeão");
            }
        }

        public IEnumerable<CampeaoEntity> RecuperarLista()
        {
            try
            {
                var campeoesEntity = CampeaoEntityFactory.Build(this._context.Campeoes);
                return campeoesEntity;
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível recuperar a lista de campeões.");
            }
        }

        public CampeaoEntity RecuperarPorId(Guid id)
        {
            try
            {
                CampeaoModel campeaoModel = this._recuperarPorId(id); // 123
                if(campeaoModel == null) return null;

                return CampeaoEntityFactory.Build(campeaoModel);
            }
            catch (System.Exception)
            {
                throw; // Não foi possível encontrar o campeão.
            }
        }
        public CampeaoEntity RecuperarPorNome(string nome)
        {
            try
            {
                CampeaoModel campeaoModel = this._context.Campeoes.FirstOrDefault(c => c.Nome == nome);
                if (campeaoModel == null) return null;

                return CampeaoEntityFactory.Build(campeaoModel);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        private CampeaoModel _recuperarPorId(Guid id)
        {
            try
            {
                CampeaoModel campeaoModel = this._context.Campeoes.FirstOrDefault(c => c.Id == id);
                if(campeaoModel == null) return null;
                
                return campeaoModel;
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível encontrar o campeão.");
            }
        }
    }
}