// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

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
    }


}