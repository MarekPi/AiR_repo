using System;
using System.Collections.Generic;

namespace Lab5
{
    public class Zadanie6
    {
        public Zadanie6()
        {
            Stack stack = new Stack();
            for(int i = 1; i <5; i++)
            {
                stack.AddItem(i);
            }
            stack.Print();
            stack.DeleteItem();
            stack.Print();
            Console.Write("Number of items: ");
            stack.ShowTheNumbersOfItems();
            Console.Write("MIN value: ");
            stack.ShowMinItem();
            Console.Write("MAX value: ");
            stack.ShowMaxItem();
            Console.WriteLine("Podaj liczbę jakiej indeks chcesz wyszukac:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Index {0} to {1}", a, stack.FindAnItem(a));
            stack.ClearAll();

        }
    }

    public class Stack
    {
        List<int> _stack;

        public Stack()
        {
            _stack = new List<int>();
        }
        public void Print()
        {
            foreach(int item in _stack)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }

        public void AddItem(int item)
        {
            _stack.Reverse();
            _stack.Add(item);
            _stack.Reverse();
        }

        public void DeleteItem()
        {
            _stack.RemoveAt(_stack.Count - 1);
        }

        public void ShowTheNumbersOfItems()
        {
            Console.WriteLine(_stack.Count);
        }

        public void ShowMinItem()
        {
            int low = _stack[0];
            foreach(int item in _stack)
            {
                if(item < low) low = item;
            }
            Console.WriteLine(low);
        }

        public void ShowMaxItem()
        {
            int max = _stack[0];
            foreach (int item in _stack)
            {
                if (item > max) max = item;
            }
            Console.WriteLine(max);
        }

        public int FindAnItem(int item)
        {
            int result = _stack.FindIndex(x => x == item);
            return result;
        }

        public void ClearAll()
        {
            _stack.Clear();
        }
    }
}
