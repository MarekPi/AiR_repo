using System;
using System.Collections.Generic;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
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
            foreach(ICepikData elem in ICepikDataList)
            {
                elem.GetCepikData();
                Console.WriteLine();
            }
            Console.WriteLine("\nIStatData:\n");
            foreach(IStatData elem in IStatDataList)
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
    }
}
