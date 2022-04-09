using Microsoft.Win32.SafeHandles;
using System;

namespace Zadanie_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznikWhile = 0;
            int licznikDoWhile = 0;
            Console.WriteLine("for:");
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.WriteLine("while:");
            while(licznikWhile < 3)
            {
                Console.WriteLine("Hello World!");
                licznikWhile++;
            }
            Console.WriteLine("do while:");
            do
            {
                Console.WriteLine("Hello World!");
                licznikDoWhile++;

            } while (licznikDoWhile < 3);
            Console.WriteLine("Czy chcesz przejść dalej?");
            Console.ReadKey();
            Console.WriteLine("if:");
            string napisHello = "Napis: \"Hello World!\" wypisany przez pętlę while pojawił się trzy razy";
            if (licznikWhile == 3)
            {
                Console.WriteLine(napisHello);
            }
            else
            {
                if(licznikWhile==2){
                    Console.WriteLine("Napis: \"Hello World\" wypisany przez pętlę while pojawił się dwa razy");
                }
                else
                {
                    Console.WriteLine("Napis: \"Hello World\" wypisany przez pętlę while pojaiwł się inną ilość razy niż 2 lub 3");
                }
            }
            Console.WriteLine("switch:");
            switch (licznikWhile)
            {
                case 2:
                    Console.WriteLine("Napis: \"Hello World\" wypisany przez pętlę while pojawił się dwa razy");
                    break;
                case 3:
                    Console.WriteLine(napisHello);
                    break;
                default:
                    Console.WriteLine("Napis: \"Hello World\" wypisany przez pętlę while pojaiwł się inną ilość razy niż 2 lub 3");
                    break;

            }
            Console.WriteLine("Dzwine, wcale nie losowe numerki:");
            Console.ReadKey();
            int b = 0;
            for(int i = 1; i<23; i++)
            {
                for(int j = 1; j <23; j++)
                {
                    b = i + j;
                    if(b%3==0 && b < 30)
                    {
                        continue;
                    }
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("tylko 6 liczb");
            Console.ReadKey();
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
                if (i > 4)
                {
                    break;
                }
            }
            int dziesięć = 200 / 20;
            int Minusjeden = 2 - 3;
            Console.WriteLine("jedynki zabronione");
            Console.ReadKey();
           
            for (int i = 0; i <= dziesięć; i -=Minusjeden)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Zaraz będzie spam");
            Console.ReadKey();
            while (1 == 1)
            {
                Console.WriteLine("spam");
            }
        }
    }
}
