using System;
namespace Lab6
{
    public class Zadanie1
    {
        public Zadanie1()
        {
            var b1 = new Fir.Bauble();
            var b2 = new Fir.Bauble();
            var b3 = new Fir.Bauble();
            b1.Add("red", "ball");
            b2.Add("blue", "star");
            b3.Add("green", "angel");
        }
    }

    public class Tree
    {
        string name;
        int age;
        public Tree() { }
        public Tree(string _name, int _age)
        {
            name = _name;
            age = _age;
        }
    }

    public class Fir : Tree
    {
        protected class Bauble
        {
            string color;
            string type;

            internal void Add(string _color, string _type)
            {
                color = _color;
                type = _type;
            }


        }
    }

    public class ChristmassTree : Fir
    {
        public ChristmassTree(string _name, int _age)
        {
            name = _name;
            age = _age; 
        }
    }
}
