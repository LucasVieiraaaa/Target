using System;
class Tar
{
    public static void Questao1()//Questão 1
    {
        Console.WriteLine("Questão 1:");
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K++;
            SOMA = +K;
        }
        Console.WriteLine(SOMA);
    }
     public static void Fibo()//Questão 2
    {
        Console.WriteLine("Questão 2: Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (PertenceASequenciaDeFibonacci(numero))
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }
    static bool PertenceASequenciaDeFibonacci(int numero)//Questão 2
    {
        int a = 0, b = 1;
        while (a <= numero)
        {
            if (a == numero)  
                return true;
            int proximo = a + b;
            a = b;
            b = proximo;
        }
        return false;
    }
    public static void Inv()//Questão 5
    {
        Console.WriteLine("Questão 5: Escreva algo: ");
        string entrada = Console.ReadLine();
        string resultado = InverterString(entrada);
        Console.WriteLine("String invertida: " + resultado);
    }
    public static string InverterString(string str)//Questão 5
    {
        char[] caracteres = str.ToCharArray();
        int comprimento = str.Length;
        char[] invertido = new char[comprimento];
        for (int i = 0; i < comprimento; i++)
            invertido[i] = caracteres[comprimento - 1 - i];

        return new string(invertido);
    }
    public static void Main()
    {
        Questao1();//Questão 1
        Fibo();//Questão 2
        Inv();//Questão 5
    }
}