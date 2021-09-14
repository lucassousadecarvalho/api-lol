using System;

namespace Lol.Infra.Models
{
    public class CampeaoModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int DanoFisico { get; set; }
        public int PoderDeHabilidade { get; set; }
        public int Armadura { get; set; }
        public int ResistenciaMagica { get; set; }
        public int Vida { get; set; }
        public string Lane { get; set; }
        public static CampeaoModelBuilder Builder() => new CampeaoModelBuilder();
        public class CampeaoModelBuilder
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public int DanoFisico { get; set; }
            public int PoderDeHabilidade { get; set; }
            public int Armadura { get; set; }
            public int ResistenciaMagica { get; set; }
            public int Vida { get; set; }
            public string Lane { get; set; } // 
            public CampeaoModelBuilder WithId(string Id)
            {
                this.Id = Id;
                return this;
            }
            public CampeaoModelBuilder WithNome(string Nome)
            {
                this.Nome = Nome;
                return this;
            }
            public CampeaoModelBuilder WithDanoFisico(int DanoFisico)
            {
                this.DanoFisico = DanoFisico;
                return this;
            }
            public CampeaoModelBuilder WithPoderDeHabilidade(int PoderDeHabilidade)
            {
                this.PoderDeHabilidade = PoderDeHabilidade;
                return this;
            }
            public CampeaoModelBuilder WithArmadura(int Armadura)
            {
                this.Armadura = Armadura;
                return this;
            }
            public CampeaoModelBuilder WithResistenciaMagica(int Resistenciamagica)
            {
                this.ResistenciaMagica = Resistenciamagica;
                return this;
            }
            public CampeaoModelBuilder WithVida(int Vida)
            {
                this.Vida = Vida;
                return this;
            }
            public CampeaoModelBuilder WithLane(string Lane) 
            {
                this.Lane = Lane;
                return this;
            }
            public CampeaoModel Build()
            {
                CampeaoModel campeao = new CampeaoModel();
                Guid.TryParse(this.Id, out Guid guid);
                
                campeao.Id = guid;
                campeao.Nome = this.Nome;
                campeao.DanoFisico = this.DanoFisico;
                campeao.PoderDeHabilidade = this.PoderDeHabilidade;
                campeao.Armadura = this.Armadura;
                campeao.ResistenciaMagica = this.ResistenciaMagica;
                campeao.Vida = this.Vida;
                campeao.Lane = this.Lane; 

                return campeao;
            }
        }
    }
}