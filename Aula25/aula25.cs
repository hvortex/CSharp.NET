using System;
class Aula25{
    static void Main(){
        int num=50;
        dobrar1(ref num);
        Console.WriteLine(num);
    }
    //passagem por referencia;
    static void dobrar1(ref int valor){
        valor*=2;
    }
    //passagem por valor;
    static void dobrar2(int valor){
        valor*=2;
    }
}