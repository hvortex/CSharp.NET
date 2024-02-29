using System;

class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido",nome);
    }
}
class Aula29{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do jogador: ");
        nome1=Console.ReadLine();

        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Théo");
        Jogador j3=new Jogador("Carla");

        j1.energia=50;
        Console.WriteLine("O nome do(a) jogador(a) 1 é: {0}",j1.nome);
        Console.WriteLine("O nome do jogador(a) 2 é: {0}",j2.nome);
        j3.energia=70;
        Console.WriteLine("O nome do(a) jogador(a) 3 é: {0}",j3.nome);
    }
}