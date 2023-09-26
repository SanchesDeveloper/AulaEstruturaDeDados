using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaDeStrings = new Queue<string>();

        filaDeStrings.Enqueue("Santos");
        filaDeStrings.Enqueue("Gremio");
        filaDeStrings.Enqueue("Inter");

        string proximoElemento = filaDeStrings.Peek();
        Console.WriteLine($"Próximo elemento da fila: {proximoElemento}");

        Console.WriteLine("Itens na fila:");
        foreach (var item in filaDeStrings)
        {
            Console.WriteLine(item);
        }
    }
}