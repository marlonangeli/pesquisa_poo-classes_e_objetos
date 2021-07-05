# Roteiro de apresentação
[Slides da apresentação](https://docs.google.com/presentation/d/17nuVnHW6ZfLs4QFkurTPuFNPO7pE62gBzA6wTqtBMG4/edit?usp=sharing)

<br>

## O que são?
<br>

- ## Classe
É um **conjunto de objetos** que possuem características **semelhantes**.
Um **molde abstrato** que descreve propriedades e comportamentos de entidades do mundo real.

Representa a abstração de um tipo de dado, objeto ou estrutura.

#### Exemplo:
- Classe **Carro**
> Veículo de 4 rodas que possui um motor, utiliza alguma fonte de
> energia para o motor, acomoda o motorista e passageiros* e possibilita
> a locomoção dos mesmos para longas distâncias.

**Atributos**       | **Funcionalidades**
---                 | ---
Potência do motor	| Ligar/Desligar carro
Cor do carro 		| Acelerar
Tipo de combustível	| Frear
Número de portas    | Abastecer
...                 | ...

<br>

- ## Objeto

É um tipo de dado, variável, função ou estrutura de dados que possui características e funcionalidades, é a referência de uma entidade real, onde é possível alterar seus atributos a partir dos métodos da classe em que o objeto pertence.

Um carro X é um objeto que pertence à classe `Carro`, pois possui atributos e funcionalidades presentes na classe

<img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/carro_vermelho.png" width=150x>

<br>

### Relação entre classes e objetos

<img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/class-carro.png" width=250x>

Modelo abstrato de um carro
x | Carro 1 | Carro 2 | Carro 3
--- | --- | --- | ---
Objeto | <img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/carro_vermelho.png" width=250x> | <img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/carro_azul.png" width=250x> | <img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/carro_verde.png" width=250x>
Cor | Vermelho | Azul | Verde
Motor | 1.0 | 1.6 | 2.0
Combustível | Gasolina | Flex | Gasolina
Nº de portas | 4 | 2 | 2


<img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/caminhao.png" width=150x>

O caminhão compartilha de alguns atributos dos carros, como **motor**, **faróis**, **motorista**, **combustível** porém propriedades como **tamanho**, **número de rodas** e **carroceria** o diferem o suficiente para classificá-lo como outro veículo.

Assim podemos perceber a herança na orientação à objetos, onde `Veiculo` seria a classe mãe, e seus filhos `Carro`, `Caminhão`, `Motocicleta`...

<br><br><br>

## Instância de uma classe

>"[...] objects are instantiated from a class, and each object is referred to as an instance of the class". - [Diane Zak](https://books.google.com.br/books?id=o_q5BwAAQBAJ&pg=PA552&dq=OOP%20instance%20terminology&hl=pt-BR&sa=X&redir_esc=y#v=onepage&q=OOP%20instance%20terminology&f=false)

>"[...] objetos são instanciados de uma classe, e cada objeto é referido como uma instância da classe". - Diane Zak

A definição de instância de classe e objeto é um tanto quanto confusa, há uma linha tênue entre as duas definições, na qual ambas podem ser intercambiáveis sem estar completamente corretas ou incorretas, de maneira mais clara, é possível dizer que a instância de uma classe é a ação de criar o objeto, e o objeto é a instanciação da classe, é o produto físico que veio do molde.

<img src="https://github.com/marlonangeli/pesquisa_poo-classes_e_objetos/blob/main/imagens/instancia_carro.png" width=150x>

Utilizando o exemplo da classe `Carro`, podemos atribuir o significado de instância da classe à fábrica do carro, e o objeto ao carro em si. A fábrica é responsável por realizar a montagem das peças e acessórios segundo o molde de criação, assim, podemos dizer que instanciar uma classe é fazer a atribuição das características à um objeto, e o objeto seria o carro fabricado a partir do molde da fábrica e com atributos que o diferenciam dos demais carros.

> "Mas e se todos os atributos forem iguais?"

Nada impede de termos dois objetos iguais, mas é errado dizer que são o mesmo objeto, já que possuem identificadores diferentes, o carro possui a placa de identificação e o objeto tem sua refência ao local armazenado em memória.

<br><br><br>

## Declaração de classe

Como exemplo, utilizaremos `C#` para declarar classes e obter objetos

A criação de uma classe é feita a partir da palavra reservada `class` e o respectivo nome da mesma:

```C#
class MyClass {
    ...
}
```
Em uma classe temos atributos que podem ser declaradas como **variáveis***
```C#
class Carro {
    string Marca;
    string Modelo;
    int Ano;
}
```
E métodos, que são as funções dentro das classes
```C#
class Carro {
    ...
    public void GetInfo() {
        Console.WriteLine("Informações do carro...");
    }
}
```

Em uma forma completa, a classe é constituída de seus atributos (ou, propriedades), do método de inicialização da classe, e de seus outros métodos

```C#
class Carro {
    string Marca;       // Atributos do carro
    string Modelo;
    int Ano;

    // O método construtor tem o mesmo nome da classe mas sem o tipo de retorno
    public Carro(string marca, string modelo, string ano) {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
    }

    // Método que exibe as informações do carro
    public void GetInfo() {
        Console.WriteLine($"Marca: {this.Marca}\nModelo: {this.Modelo}\nAno: {this.Ano}");
    }
}
```
Veja que no construtor, utilizamos `this` para referenciar ao atributo da própria classe, no exemplo não seria necessário pois o nome dos argumentos inicia com letra minuscula, mas em casos com o mesmo nome, o prefixo `this` é usado para referenciar o atributo da classe.


Agora que temos um simples modelo de classe criado, é possível criarmos um objeto a partir dela.

Na classe padrão `Program` e no método de inicialização `Main()` vamos criar um objeto da classe `Carro`

```C#
class Program {
    static void Main() {
        Carro carro = new Carro(marca: "Fiat", modelo: "Uno", ano: 2010);
        carro.GetInfo();
    }
}
/* Saída:
Marca: Fiat
Modelo: Uno
Ano: 2010
*/
```
No exemplo acima declaramos uma variável do tipo `Carro` com nome `carro` e através do operador `new` **instanciamos** o objeto com as propriedades passadas pelo construtor da classe. Após, com o objeto `carro` criado, utilizamos o método `GetInfo()` da classe `Carro` para mostrar as informações do objeto criado.

<br><br><br>

## Propriedades e Métodos

Veremos agora, conceitos mais aprofundados sobre propriedades e métodos, relembrando:
### Propriedades
Características de um objeto, descrevem aspectos e estados do objeto

### Métodos
São funções que utilizam ou alteram as propriedades para um fim específico

Voltamos ao nosso exemplo da classe `Carro`:
```C#
class Carro {
    string Marca;
    string Modelo;
    int Ano;
    public Carro(string marca, string modelo, int ano) {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
    }

    public void GetInfo() {
        Console.WriteLine($"Marca: {this.Marca}\nModelo: {this.Modelo}\nAno: {this.Ano}");
    }
}
```

Neste exemplo, temos três atributos, mas sem o modificador de acesso, assim, como padrão, o compilador transforma os atributos em `private`, ou seja, não é possível acessá-los fora da classe.

```C#
class Program {
    static void Main() {
        Carro carro = new Carro("Fiat", "Uno", 2010);
        carro.Ano = 2020; // ERRO: atributo privado
    }
}
```
No exemplo acima, ao tentarmos acessar algum atributo, recebemos um erro, pois o mesmo não é visível fora do escopo da classe, porém, no mesmo exemplo, encontramos outro problema, caso alteramos o modificador para `public`, após criado um objeto, poderemos modificar seus parâmetros (o que pode causar problemas no programa), pois o atributo `Ano`, não pode ser modificável, porém um atributo como `Cor` poderia.

Para resolver este problema, temos as propriedades da classe, que funcionam semelhantes às variáveis, mas com maiores possibilidades.

Exemplo de propriedade:

```C#
public enum Cor {
    Vermelho, Azul, Verde, Branco, Preto
}

class Carro {
    public string Marca { get; }
    public string Modelo { get; }
    public int Ano { get; }
    public Cor Cor { get; set; }
    ...
}
```

No exemplo acima, as propriedades `Marca`, `Modelo` e `Ano`, possuem acesso *Somente Leitura*, pois são aspectos que não podem ser alterados após a criação do objeto, já a propriedade `Cor` possui acesso de *Leitura e Escrita*, já que é possível alterar a cor do carro futuramente.
OBS.: As propriedades são visíveis por que possuem acesso `public`.

Exemplo de acesso das propriedades:

```C#
class Program {
    static void Main() {
        Carro carro = new Carro(marca: "Fiat", modelo: "Uno", ano: 2010, cor: Cor.Verde);
        Console.WriteLine(carro.Marca); // Propriedade somente leitura
        Console.WriteLine(carro.Cor);   // Leitura do valor "get"

        carro.Cor = Cor.Azul;           // Alteração do valor "set"
        Console.WriteLine(carro.Cor);   // Leitura do valor alterado "get"
    }
}
/* Saída:
Fiat
Verde
Azul
*/
```

Os acessadores `get` e `set` são utilizados comumente para alterar o acesso dos valores, porém é possível utilizá-los com outras finalidades, como:

```C#
class Carro {
    ...
    private double _velocidade;
    public double Velocidade {
        get { return _velocidade; }
        private set { _velocidade = value; }
    }
        
    public Carro(...) {
        ...
        Velocidade = 0; // O carro inicia parado
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
```
No exemplo acima, criamos a variável privada `_velocidade` por convenção de nomenclatura de atributos privados, e a propriedade `Velocidade` que é acessado como `Somente Leitura`, mas pode ser modificado por seus métodos.

A mudança da propriedade `Velocidade` a partir dos métodos `Accelerate` e `Break` permite o controle correto da velocidade do carro, sem haja problemas no programa.
OBS.: Ainda no acesso `private`, dentro da classe é possível acessar o valor de `_velocidade`, porém ao utilizarmos a propriedade, evitamos possíveis erros ao atributo principal.


Alterando as propriedades do objeto a partir dos métodos:
```C#
class Program {
    static void Main() {
        var carro = new Carro(marca: "Fiat", modelo: "Uno", ano: 2010, cor: Cor.Verde);
        carro.Accelerate(20);   // Acelera até 20Km/h
        carro.GetSpeed();

        carro.Break(30);        // Freia 30Km/h, ou seja, o carro para
        carro.GetSpeed();

        carro.Accelerate(10);   // Acelera novamente
        carro.GetSpeed();
    }
}
/* Saída:
A velocidade do carro é: 20 Km/h
O carro está parado!
A velocidade do carro é: 10 Km/h
*/
```

> Propriedades **NÃO** são variáveis, não é possível utilizar elas como argumentos `ref` e `out` em funções.

É possível ver as propriedades e métodos até nos princípios básicos de uma linguagem, por exemplo:
Ao declararmos uma variável do tipo `int`, estamos na verdade instanciando um objeto da classe `int` que possui propriedades e métodos para tratar dados do tipo inteiro.

```C#
var variavel = new int();   // Declara variável da classe int.Int32()
Console.WriteLine(variavel.GetType());  // Mostra o tipo do objeto com o método GetType

variavel = int.Parse(Console.ReadLine());  /* Utiliza método da classe int para converter
                                            string em inteiro */
string palavra = "Objeto";  // Cria objeto da classe String
Console.WriteLine(palavra.Length);  // Obtém o tamanho da string com a propriedade Length
```         

<br><br><br>

# Referências

### Geral:

- [Introdução ao C# - Módulo 1](https://www.udemy.com/share/102YvK2@PkdgV2JbTFYGd0dBAnZOfT5uY1Q=/)
- [Introdução ao C# - Módulo 2](https://www.udemy.com/share/103obo2@PUdjfVpcSV0KckVCBkhNfT5uY1c=/)


### Definição de classes e objetos:

- [Alura](https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos?gclid=Cj0KCQjw8vqGBhC_ARIsADMSd1DKHbAbBqeFu9Imi7Rl_vl6o8CZKuDUyvs9L8iyFZ_naxn91V52FUkaAnmcEALw_wcB)
- [DCA/Unicamp](https://www.dca.fee.unicamp.br/cursos/PooJava/classes/conceito.html)
- [Wikipedia - Classe](https://pt.wikipedia.org/wiki/Classe_(programa%C3%A7%C3%A3o))
- [Wikipedia - Objeto](https://pt.wikipedia.org/wiki/Objeto_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)) 
- [Facom/UFU](http://www.facom.ufu.br/~elaine/disc/POO/Aula3-POO-ConceitosBasicos.pdf)


### Relação entre classes e objetos:

- [WikiBooks](https://pt.wikibooks.org/wiki/Programa%C3%A7%C3%A3o_Orientada_a_Objetos/Classes_e_Objetos)


### Instância de uma classe:

- [Stack Overflow](https://pt.stackoverflow.com/questions/192233/diferen%C3%A7a-entre-objeto-e-inst%C3%A2ncia)
- [Wikipedia](https://pt.wikipedia.org/wiki/Inst%C3%A2ncia_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o))


### Propriedades e métodos:

- [Docs.Microsoft](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties#the-set-accessor)
- [Macoratti.net](http://www.macoratti.net/17/01/c_camprop1.htm)