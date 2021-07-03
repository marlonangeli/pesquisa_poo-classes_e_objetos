using System;

namespace codigos {
    public class Carro {

        public string Marca { get; }
        public string Modelo { get; }
        public Cor Cor { get; set; }
        
        public Carro(string marca, string modelo, Cor cor) {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }

        public void GetInfo() {
            Console.WriteLine($"Marca: {this.Marca}\nModelo: {this.Modelo}\nCor: {this.Cor}");
        }
    }

    public enum Cor {
        Vermelho, Azul, Verde, Branco, Preto
    }
}
