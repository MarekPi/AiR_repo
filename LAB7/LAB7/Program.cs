﻿using System;
using System.Collections.Generic;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            Zadanie3();
            static void Zadanie1()
            {
                List<ICepikData> ICepikDataList = new List<ICepikData>();
                List<IStatData> IStatDataList = new List<IStatData>();
                List<IPoliceData> IPoliceDataList = new List<IPoliceData>();
                Auto A = new Auto("Osobowe", "Opel", 1700, "1234abcd", "KR1234", 2005, "czerwony", "Marek", "Piekarz", "123456789", "0987654321", 2010, 9);
                Auto B = new Auto("Dostawce", "Volkswagen", 2500, "zxc123", "KR4567", 2018, "czarny", "Jan", "Kowalski", "789435234", "7635475869", 2019, 1);

                ICepikDataList.Add(A);
                IStatDataList.Add(A);
                IPoliceDataList.Add(A);

                ICepikDataList.Add(B);
                IStatDataList.Add(B);
                IPoliceDataList.Add(B);

                Console.WriteLine("ICepikData:\n");
                foreach (ICepikData elem in ICepikDataList)
                {
                    elem.GetCepikData();
                    Console.WriteLine();
                }
                Console.WriteLine("\nIStatData:\n");
                foreach (IStatData elem in IStatDataList)
                {
                    elem.GetStatData();
                    Console.WriteLine();
                }
                Console.WriteLine("\nIPoliceData:\n");
                foreach (IPoliceData elem in IPoliceDataList)
                {
                    elem.GetPoliceData();
                    Console.WriteLine();
                }
            }
            static void Zadanie2()
            {
                Point p1 = new Point(1, 0);
                Point p2 = new Point(2, 3);
                Point p3 = p1 + p2;
                Console.WriteLine("P3 = P1+P2 :");
                p3.print();
                if (p1)
                {
                    Console.WriteLine("TRUE");
                }
                else
                {
                    Console.WriteLine("FALSE");
                }
                Point p4 = new Point(2, 2);
                Point p5 = new Point(2, 2);
                Console.WriteLine("Czy P4 == P5? : {0}", p4 == p5);
                p5++;
                p5.print();
                p5--;
                p5.print();

                Point p6 = 10;
                p6.print();
                Console.WriteLine("Suma wartosci wspolrzednych punktu p6: {0}", (int)p6);
            }
            static void Zadanie3()
            {
                Zadanie3 z3 = new Zadanie3();
                z3.Zad3();
            }

        }
    }
}
