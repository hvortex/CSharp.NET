using System;

class Jogador{
    public int energia=100;
    public bool vivo=true;
}
class Aula28{
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

        j1.energia=50;
        Console.WriteLine("Energia do jogador 1: {0}",j1.energia);
        j2.energia=70;
        Console.WriteLine("Energia do jogador 2: {0}",j2.energia);
        Console.WriteLine("Energia do jogador 3: {0}",j3.energia);
    }
}
