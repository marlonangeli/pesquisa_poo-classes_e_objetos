using System;

namespace codigos {
    class Program {
        static void Main() {
            Carro carro1 = new Carro(marca: "Fiat", modelo: "Uno", ano: 2010, cor: Cor.Verde);
            Console.WriteLine($"Cor do carro: {carro1.Cor}");
            carro1.Cor = Cor.Preto;
            Console.WriteLine($"Cor do carro após troca: {carro1.Cor}");
            
            var carro2 = new Carro("Volkswagen", "Gol", 2021, Cor.Vermelho);
            carro2.Accelerate(40);
            carro2.GetSpeed();
            carro2.Break(25);
            carro2.GetSpeed();
            // carro2.Velocidade = 50; Erro: Acesso privado à propriedade

            carro1.GetInfo();
            carro2.GetInfo();
            
        }
    }
}
