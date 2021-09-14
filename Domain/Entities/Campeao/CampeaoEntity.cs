using System;
using Lol.Domain.Entities.Campeao.Types;

namespace Lol.Domain.Entities.Campeao
{
    public class CampeaoEntity
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public int DanoFisico { get; set; } //100 á 300 
        public int PoderDeHabilidade { get; set; } // 150 á 500
        public int Armadura { get; set; } // 50 à 100
        public int ResistenciaMagica { get; set; } // 70 à 150
        public int Vida { get; set; } // 500 à 1500
        public double Pontuacao { get => this.GetPontuacao(); }
        public Lane Lane { get; set; }
        public double GetPontuacao() 
        {
            double dano = this.DanoFisico + (this.PoderDeHabilidade / 1.25); // 220 -> 700
            double defesa = (this.Vida + (this.Armadura * this.ResistenciaMagica) / 2) / 10; // 225 - 900
            double total = defesa + dano; // 445 - 1.600

            return total;
        }
        // public void Duelar(CampeaoEntity campeao)
        // {
        //     if (this.Pontuacao < campeao.Pontuacao) 
        //     {
        //         Console.WriteLine($"O campeão {this.Nome} venceu do {campeao.Nome}!");
        //     }
        //     Console.WriteLine($"O campeão {this.Nome} perdeu para {campeao.Nome}");
        // }
        public static CampeaoEntityBuilder Builder() => new CampeaoEntityBuilder();
        public class CampeaoEntityBuilder
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public int DanoFisico { get; set; }
            public int PoderDeHabilidade { get; set; }
            public int Armadura { get; set; }
            public int ResistenciaMagica { get; set; }
            public int Vida { get; set; }
            public string Lane { get; set; } // 
            public CampeaoEntityBuilder WithId(string Id)
            {
                this.Id = Id;
                return this;
            }
            public CampeaoEntityBuilder WithNome(string Nome)
            {
                this.Nome = Nome;
                return this;
            }
            public CampeaoEntityBuilder WithDanoFisico(int DanoFisico)
            {
                this.DanoFisico = DanoFisico;
                return this;
            }
            public CampeaoEntityBuilder WithPoderDeHabilidade(int PoderDeHabilidade)
            {
                this.PoderDeHabilidade = PoderDeHabilidade;
                return this;
            }
            public CampeaoEntityBuilder WithArmadura(int Armadura)
            {
                this.Armadura = Armadura;
                return this;
            }
            public CampeaoEntityBuilder WithResistenciaMagica(int Resistenciamagica)
            {
                this.ResistenciaMagica = Resistenciamagica;
                return this;
            }
            public CampeaoEntityBuilder WithVida(int Vida)
            {
                this.Vida = Vida;
                return this;
            }
            public CampeaoEntityBuilder WithLane(string Lane) 
            {
                this.Lane = Lane;
                return this;
            }
            public CampeaoEntity Build()
            {
                CampeaoEntity campeao = new CampeaoEntity();
                Guid.TryParse(this.Id, out Guid guid);
                
                campeao.Id = guid;
                campeao.Nome = new Nome(this.Nome);
                campeao.DanoFisico = this.DanoFisico;
                campeao.PoderDeHabilidade = this.PoderDeHabilidade;
                campeao.Armadura = this.Armadura;
                campeao.ResistenciaMagica = this.ResistenciaMagica;
                campeao.Vida = this.Vida;
                campeao.Lane = new Lane(this.Lane); // "Top"

                return campeao;
            }
        }
    }
}