using System;
using System.Collections;
using System.Collections.Generic;

public enum Week { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };
public enum Size { small = 10, medium = 100, big = Int32.MaxValue};

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4a();
            //Zadanie4b();
            //Zadanie5();
            //Zadanie6();
            //Zadanie7(); //zakomentowane z powodu błędu przeciążenia
            //Zadanie8();
            //Zadanie9();
            //Zadanie10()

            static void Zadanie1()
            {
                Console.WriteLine("\nZADANIE 1");
                const int rad = 3;
                double x, y;
                List<Point2D> list = new List<Point2D>();
                for (int i = 0; i <= 2; i++)
                {
                   
                    Console.WriteLine("Podaj 1 wspolrzedna punktu {0}", i);
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj 2 wspolrzedna punktu {0}", i);
                    y = Convert.ToDouble(Console.ReadLine());

                    Point2D p = new Point2D(x, y);
                    list.Add(p);
                }

                int inside_flag = 0;

                while (inside_flag == 0)
                {
                    Console.WriteLine("\nPodaj 1 wspolrzedna punktu sprawdzanego");
                    x = Convert.ToDouble(Console.ReadLine());
                    if (x < 0)
                    {
                        Console.WriteLine("Wprowadzono ujemna wspolrzedna, koniec programu.");
                        break;
                    }
                    Console.WriteLine("Podaj 2 wspolrzedna punktu sprawdzanego");
                    y = Convert.ToDouble(Console.ReadLine());
                    if (y < 0)
                    {
                        Console.WriteLine("Wprowadzono ujemna wspolrzedna, koniec programu.");
                        break;
                    }
                    Point2D p_sprawdzany = new Point2D(x, y);

                    double min_distance = double.MaxValue;
                    foreach (Point2D p in list)
                    {
                        double distance = p_sprawdzany.Dist(p);
                        if (distance < min_distance)
                        {
                            min_distance = distance;
                        }
                        if (distance < rad)
                        {
                            Console.WriteLine("\nPunkt o wspolrzednych:");
                            p_sprawdzany.Print2DPoint();
                            Console.WriteLine("jest wewnątrz kola o promieniu {0} i srodku w punkcie:", rad);
                            p.Print2DPoint();
                            inside_flag = 1;
                            break;
                        }
                        
                    }
                    if (inside_flag == 0)
                    {
                        Console.WriteLine("\nPunkt o wspolrzednych:");
                        p_sprawdzany.Print2DPoint();
                        Console.WriteLine("nie znajduje sie wewnatrz zadnego z okregow. Odleglosc do najblizszego punktu wynosi: {0}\nWprowadz nowy punkt do sprawdzenia:", min_distance);
                    }
                }

            }

            static void Zadanie2()
            {
                Console.WriteLine("\nZADANIE 2");
                //Point2D_v2 p;
                //string test = p.ToString();
                //Console.WriteLine(test);
                // Powyższy program nie kompiluje się, uzyskujemy błąd: Use of unassigned local variale 'p'

                Point2D_v2 p = new Point2D_v2();
                string test = p.ToString();
                Console.WriteLine(test);
            }

            static void Zadanie3()
            {
                Console.WriteLine("\nZADANIE 3");
                int int_counter = 0;
                int float_counter = 0;
                int string_counter = 0;
                int a;
                float b;
                Console.WriteLine("Podaj kolejne dane z klawiatury. Aby zakonczyc podaj -1");
                string line = Console.ReadLine();
                while (line != "-1")
                {
                    if (int.TryParse(line, out a))
                    {
                        int_counter += 1;
                    }
                    if (!int.TryParse(line, out a) && float.TryParse(line, out b))
                    {
                        float_counter += 1;
                    }
                    if (!int.TryParse(line, out a) && !float.TryParse(line, out b))
                    {
                        string_counter += 1;
                    }
                    line = Console.ReadLine();
                }
                Console.WriteLine("\nLiczba wystąpień różnych typów danych:");
                Console.WriteLine("Int: {0}\nFloat: {1}\nString: {2}", int_counter, float_counter, string_counter);
            }

            static void Zadanie4a()
            {
                Console.WriteLine("\nZADANIE 4 - część pierwsza");
                Console.WriteLine("Podaj liczbę z zakresu 1 - 7 lub -1 aby zakonczyc.");
                int a = int.Parse(Console.ReadLine());
                while (a != -1)
                {
                    Week weekday;
                    weekday = (Week)a;
                    Console.WriteLine(weekday);

                    a = int.Parse(Console.ReadLine());
                }
            }

            static void Zadanie4b()
            {
                Console.WriteLine("\nZADANIE 4 - część druga");
                int a = int.Parse(Console.ReadLine());
                foreach (int i in Enum.GetValues(typeof(Size)))
                {
                    if(a<i)
                    {
                        Size _size;
                        _size = (Size) i;
                        Console.WriteLine("{0}<{1}", a, i);
                        Console.WriteLine("Range: {0}", _size);
                        break;
                    }
                    
                }
            }

            static void Zadanie5()
            {
                Console.WriteLine("\nZADANIE 5");
                string[] array1 = { "a", "ą", "e", "ę", "i", "o", "u", "y" };
                string[] array2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                string a = Console.ReadLine();
                if(Array.IndexOf(array1, a) != -1)
                {
                    Console.WriteLine("Znak {0} jest samogloska", a);
                }
                else if (Array.IndexOf(array2, a) != -1)
                {
                    Console.WriteLine("Znak {0} jest cyfra", a);
                }
                else
                {
                    Console.WriteLine("Znak {0} jest innym znakiem niz samogloska lub cyfra", a);
                }
                    

            }

            static void Zadanie6()
            {
                Console.WriteLine("\nZADANIE 6");
                Console.WriteLine("Podaj tekst, ktory chcesz rozstrzelic:");
                string s = Console.ReadLine();
                char[] c = s.ToCharArray();
                Console.WriteLine(string.Join(" ", c));
            }

            static void Zadanie7()
            {
                Console.WriteLine("\nZADANIE 7");
                int x = Int32.MaxValue;
                Console.WriteLine(x);
                checked
                {
                    int xx = x + 10;
                    Console.WriteLine(xx);
                }
            }

            static void Zadanie8()
            {
                Console.WriteLine("\nZADANIE 8");
                int xx = 1;
                int yy = 2;
                Point p = new Point(xx, yy);
                Coords c = new Coords(xx, yy);
                Console.WriteLine("Przed wykonaniem modyfikacji");
                p.Print();
                c.Print();
                Fun1(p);
                Fun2(c);
                Console.WriteLine("Po modyfikacji");
                p.Print();
                c.Print();

                static void Fun1(Point p)
                {
                    p.x = p.x + 1;
                    p.y = p.y + 1;
                }

                static void Fun2(Coords c)
                {
                    c.x = c.x + 1;
                    c.y = c.y + 1;
                }

                //Czesc druga, porownania
                Point p1 = new Point(xx, yy);
                Point p2 = new Point(xx, yy);
                Coords c1 = new Coords(xx, yy);
                Coords c2 = new Coords(xx, yy);

                Console.WriteLine("Point.Equals(p1,p2): {0}", Point.Equals(p1, p2));
                Console.WriteLine("Coords.Equals(c1,c2): {0}", Coords.Equals(c1, c2));
                Console.WriteLine("p1.Equals(p2): {0}", p1.Equals(p2));
                Console.WriteLine("c1.Equals(c2): {0}", c1.Equals(c2));
                Console.WriteLine("Point.ReferenceEquals(p1,p2): {0}", Coords.ReferenceEquals(p1, p2));
                Console.WriteLine("Coords.ReferenceEquals(c1,c2): {0}", Coords.ReferenceEquals(c1, c2));
            }

            static void Zadanie9()
            {
                Console.WriteLine("\nZADANIE 9");
                float num1 = 0, num2 = 0;
                Console.WriteLine("Podaj pierwsza liczbe:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj druga liczbe:");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj rodzaj operacji:");
                string ope = Console.ReadLine();
                switch (ope)
                {
                    case "+":
                        Console.WriteLine("\nWynik: {0}{1}{2}={3}", num1, ope, num2, num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine("\nWynik: {0}{1}{2}={3}", num1, ope, num2, num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine("\nWynik: {0}{1}{2}={3}", num1, ope, num2, num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine("\nWynik: {0}{1}{2}={3}", num1, ope, num2, num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Podano zly operator");
                        break;
                }
            }

            static void Zadanie10()
            {
                Console.WriteLine("\nZADANIE 10");
                //Implicite
                int i = 123;
                double d = i;

                //Explicite
                double dd = 123.4;
                int ii = (int)d;

            }
        }

    }

}
