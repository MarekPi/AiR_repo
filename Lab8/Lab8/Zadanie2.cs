using System;
namespace Lab8
{
    public class Zadanie2
    {

        public delegate void OnDigitDelegate();
        public event OnDigitDelegate OnDigit;
        void HandleOnDigit()
        {
            Console.WriteLine("Naciśnięto cyfrę!");
        }

        public delegate void OnCharacterDelegate();
        public event OnCharacterDelegate OnCharacter;
        void HandleOnCharacter()
        {
            Console.WriteLine("Naciśnięto literę!");
        }

        public void zad2()
        {
            OnDigit += new OnDigitDelegate(HandleOnDigit);
            OnCharacter += new OnCharacterDelegate(HandleOnCharacter);

            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(Char.IsDigit(c))
                {
                    OnDigit();
                }
                if(Char.IsLetter(c))
                {
                    OnCharacter();
                }
            }
            while (Char.IsLetter(c) || Char.IsDigit(c));
        }

    }
}
