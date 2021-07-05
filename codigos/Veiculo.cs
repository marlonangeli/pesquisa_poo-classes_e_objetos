using System;

namespace codigos {
    class Carro {
        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }
        public Cor Cor { get; set; }

        private double _velocidade;
        public double Velocidade {
            get { return _velocidade; }
            private set { _velocidade = value; }
        }
            
        public Carro(string marca, string modelo, int ano, Cor cor) {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
            Velocidade = 0; // O carro inicia parado
        }

        public void GetInfo() {
            // Método que mostra informações do carro
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano: {this.Ano}");
            Console.WriteLine($"Cor: {this.Cor}");
            Console.WriteLine($"Velocidade: {this._velocidade} Km/h");
        }

        public void Accelerate(double value) {  // Acelera o carro
            if (value > 0)
                Velocidade += value;
        }

        public void Break(double value) {       // Freia o carro
            if (value > 0) {
                if (value <= Velocidade)
                    Velocidade -= value;
                else Velocidade = 0;
            }
        }

        public void GetSpeed() {                // Mostra a velocidade
            if (Velocidade == 0)
                Console.WriteLine("O carro está parado!");
            else
                Console.WriteLine($"A velocidade do carro é: {Velocidade} Km/h");            
        }    
    }

    // Estrutura do tipo Cor
    public enum Cor {
        Vermelho, Azul, Verde, Branco, Preto
    }
}
