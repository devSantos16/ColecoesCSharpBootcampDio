// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using ColecoesCSharpBootcampDio.Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Pessoa p = new Pessoa("Emanuel dos Santos Paz", 22);

        // Era pra ta funcionando, não sei pq não está (string nome, int idade) = p;
        // Tupla
        (int, string, string) tupla = (22, "Emanuel", "dos Santos Paz");
        ValueTuple<int, string, string> outroExemploTupla = (22, "Emanuel", "dos Santos Paz");
        // Tupla com metodo, o underline representa informação não usada
        var (sucesso, linhas, _) = LeituraArquivo.LerArquivo("LeituraArquivo.txt");
        // Dictionary
        Dictionary<int, string> dic = new Dictionary<int, string>();
        // Fila

        Queue<int> fila = new Queue<int>();
        // Pilha
        Stack<int> pilha = new Stack<int>();

        // Adiciona um elemento no topo da pilha
        pilha.Push(2);
        pilha.Push(4);
        pilha.Push(6);
        pilha.Push(8);
        pilha.Push(10);
        pilha.Pop();

        dic.Add(1, "Portugues");
        dic.Add(2, "Ingles");
        dic.Add(3, "Espanhol");
        dic.Remove(1);

        dic[2] = "Ingles e Espanhol é fisk";

        // Adiciona uma propriedade no ultimo elemento da fila
        fila.Enqueue(4);
        fila.Enqueue(2);

        foreach (var itens in fila)
        {
            // Console.WriteLine(itens);
        }

        fila.Dequeue();

        foreach (var itens in fila)
        {
            // Console.WriteLine(itens);
        }

        foreach (var itens in pilha)
        {
            Console.WriteLine(itens);
        }

        foreach (KeyValuePair<int, string> item in dic)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine(tupla.Item1);

        if (sucesso)
        {
            //    Console.WriteLine($"Numero de linha: {tuplaArquivo.Item3}");
            foreach (string item in linhas)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Não foi encontrado o arquivo desejado");
        }
    }
}