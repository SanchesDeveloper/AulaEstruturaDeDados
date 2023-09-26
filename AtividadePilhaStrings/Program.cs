﻿using System;
using System.Collections.Generic;

public class CustomStack
{
    private Stack<string> stack;

    public CustomStack()
    {
        stack = new Stack<string>();
    }

    public void Push(string item)
    {
        stack.Push(item);
    }

    public string Pop()
    {
        if (!IsEmpty())
        {
            return stack.Pop();
        }
        else
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
    }

    public string Peek()
    {
        if (!IsEmpty())
        {
            return stack.Peek();
        }
        else
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void PrintStack()
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        CustomStack customStack = new CustomStack();

        customStack.Push("Bag de calcario");
        customStack.Push("Bag de fosfato");
        customStack.Push("Bag de Erva");

        Console.WriteLine("Pilha inicial:");
        customStack.PrintStack();

        Console.WriteLine("\nPop: " + customStack.Pop());
        Console.WriteLine("Peek: " + customStack.Peek());

        Console.WriteLine("\nPilha após operações:");
        customStack.PrintStack();

        Console.WriteLine("\nA pilha está vazia? " + customStack.IsEmpty());
    }
}