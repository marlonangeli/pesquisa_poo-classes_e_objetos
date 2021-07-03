using System;

namespace codigos {
    class Program {
        static void Main() {
            Carro carro = new Carro(marca: "Ford", modelo: "Fiesta", cor: Cor.Azul);
            carro.GetInfo();
        }
    }
}
