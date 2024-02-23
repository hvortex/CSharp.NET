using System;
class Aula13{
    static void Main(){

        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado;

        Console.Write("digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());
        
        Console.Write("digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res = n1+n2+n3+n4;

        //>=60 - Aprovado
        //59 e 40 - Recuperação
        //<40 - Reprovado

        if(res >= 60){
            resultado = "Aprovado";
        }else if(res < 40){
            resultado = "Reprovado";
        }else{
            resultado = "Recuperação";
        }

            Console.WriteLine("Nota: {0} - Resultado: {1}",res,resultado);
        
    }
}