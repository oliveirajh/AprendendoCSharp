using System;


interface IVeiculo {
    void ExibirInformacoes();

}
class Veiculo : IVeiculo {
    private string Marca { get; set; }
    private string Modelo { get; set; }
    private int Ano { get; set; }

    public Veiculo(string Marca, string Modelo, int Ano) {
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Ano = Ano;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}, Ano: {Ano}");
    }

}

class Carro: Veiculo {
    private int QuantPortas { get; set; }

    public Carro(string Marca, string Modelo, int Ano, int quantPortas): base(Marca, Modelo, Ano)
    {
        this.QuantPortas = quantPortas;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Quantidade de Portas {this.QuantPortas}");
    }
}

class Moto : Veiculo
{
    private bool Carenagem { get; set; }

    public Moto(string Marca, string Modelo, int Ano, bool Carenagem) : base(Marca, Modelo, Ano)
    {
        this.Carenagem = Carenagem;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Tem Carenagem? {this.Carenagem}");
    }
}

class Program{
    static void Main(string[] args) {
        Carro meuHonda = new Carro("Honda", "Civic", 1999, 2);
        meuHonda.ExibirInformacoes();

        Moto minhaMeiota = new Moto("Yamaha", "XT660", 2018, true);
        minhaMeiota.ExibirInformacoes();
    }
}