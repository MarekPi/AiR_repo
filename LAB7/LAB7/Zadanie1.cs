using System;
namespace LAB7
{
    interface ICepikData
    {
        void GetCepikData();
    }
    interface IStatData
    {
        void GetStatData();
    }
    interface IPoliceData
    {
        void GetPoliceData();
    }

    public class Auto : ICepikData, IStatData, IPoliceData
    {
        string typ;
        string marka;
        int pojemnosc;
        string VIN;
        string numer_rejestracyjny;
        int rok_produkcji;
        string kolor;
        string imie;
        string nazwisko;
        string pesel;
        string numer_dokumentu;
        int rok_zakupu;
        int liczba_punktow_karnych;


        public Auto(string _typ, string _marka, int _pojemnosc, string _VIN, string _numer_rejestracyjny, int _rok_produkcji, string _kolor,
            string _imie, string _nazwisko, string _pesel, string _numer_dokumentu, int _rok_zakupu, int _liczba_punktów_karnych)
        {
            typ = _typ;
            marka = _marka;
            pojemnosc = _pojemnosc;
            VIN = _VIN;
            numer_rejestracyjny = _numer_rejestracyjny;
            rok_produkcji = _rok_produkcji;
            kolor = _kolor;
            imie = _imie;
            nazwisko = _nazwisko;
            pesel = _pesel;
            numer_dokumentu = _numer_dokumentu;
            rok_zakupu = _rok_zakupu;
            liczba_punktow_karnych = _liczba_punktów_karnych;
        }

        public void GetCepikData()
        {
            Console.WriteLine("Pojazd:\nTyp:{0} Marka:{1}\nPojemnosc:{2} VIN:{3}\nNumer:{4} Rok:{5} Kolor:{6}\nWlasciciel:\n{7} {8} Pesel: {9}\nDokument: {10} Rok zakupu: {11}",
                this.typ, this.marka, this.pojemnosc, this.VIN, this.numer_rejestracyjny, this.rok_produkcji, this.kolor,
                this.imie, this.nazwisko, this.pesel, this.numer_dokumentu, this.rok_zakupu);
        }
        public void GetStatData()
        {
            Console.WriteLine("Pojazd:\nTyp:{0} Marka:{1}\nPojemnosc:{2} VIN:{3}\nNumer:{4} Rok:{5} Kolor:{6}",
                this.typ, this.marka, this.pojemnosc, this.VIN, this.numer_rejestracyjny, this.rok_produkcji, this.kolor);
        }

        public void GetPoliceData()
        {
            Console.WriteLine("Pojazd:\nTyp:{0} Marka:{1}\nPojemnosc:{2} VIN:{3}\nNumer:{4} Rok:{5} Kolor:{6}\nWlasciciel:\n{7} {8} Pesel: {9}\nDokument: {10} Rok zakupu: {11}\nPunktów karnych: {12}",
                this.typ, this.marka, this.pojemnosc, this.VIN, this.numer_rejestracyjny, this.rok_produkcji, this.kolor,
                this.imie, this.nazwisko, this.pesel, this.numer_dokumentu, this.rok_zakupu, this.liczba_punktow_karnych);
        }
    }


}
