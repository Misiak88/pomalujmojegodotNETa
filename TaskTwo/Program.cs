using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funkcja wywołująca zadanie 1
            QuestOne();
            // Funkcja wywołująca zadanie 2
            QuestTwo();
            // Funkcja wywołująca zadanie 3
            QuestThree();
            // Funkcja wywołująca zadanie 4
            QuestFour();
            // Funkcja wywołująca zadanie 5
            QuestFive();
            // Funkcja wywołująca zadanie 6
            QuestSix();
            // Funkcja wywołująca zadanie 7
            QuestSeven();
            // Funkcja wywołująca zadanie 8
            QuestEight();
        }
        static void QuestOne()
        {
            //Zad. 1.
            //Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int, które
            //zostaną zadeklarowane w kodzie programu.Zwróć uwagę na zachowanie programu i wyświetlone
            //komunikaty.

            // Deklaracja dwóch zmiennych typu całkowitoliczbowego
            int compareOne = 100, compareTwo = 20;

            // Wykorzystanie funkcji warunkowej if bez klamr.
            // Klamry mozna pominać tylko w sytuacji gdy w instrukcji warunkowej jest tylko jedna instrukcja
            if (compareOne > compareTwo)
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest wieksza od {compareTwo}");
            else
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest mniejsza od {compareTwo}");

        }
        static void QuestTwo()
        {
            //Zad. 2.
            //Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int ze zdefiniowanymi
            //wartościami, które będą przez Ciebie podane w kodzie.Wypisz wynik porównania w konsoli.

            // Deklaracja dwóch zmiennych typu całkowitoliczbowego
            int compareOne = 100, compareTwo = 20;

            // Wykorzystanie funkcji warunkowej if z klamrami
            if (compareOne > compareTwo)
            {
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest wieksza od {compareTwo}");
            }
            else
            {
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest mniejsza od {compareTwo}");
            }
        }
        static void QuestThree()
        {
            //Zad. 3.
            //Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int, których wartości
            //zostaną pobrane z konsoli. Wypisz wynik porównania w konsoli.

            // Inicjalizacja i deklaracja zmienych typu całkowitoliczbowego za pomoca metody Console.Readline();
            Console.WriteLine("Prosze podac wartosc 1 liczby całkowitoliczbowej");
            int compareOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podac wartosc 2 liczby całkowitoliczbowej");
            int compareTwo = Int32.Parse(Console.ReadLine());

            // Wykorzystanie funkcji warunkowej if z klamrami do porównania która liczba jest wieksza.
            if (compareOne > compareTwo)
            {
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest wieksza od {compareTwo}");
            }
            else
            {
                Console.WriteLine($"Zdeklarowana liczba {compareOne} jest mniejsza od {compareTwo}");
            }


        }
        static void QuestFour()
        {
            //Zad. 4.
            //Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest większa od 5 i
            //mniejsza od 20. Wypisz wynik w konsoli.

            // Deklaracja stałych zmiennych typu całkowitoliczbowego do porównania czy podana liczba 
            // mieści się w zdeklarowanym zakresie <5:20>
            const int a = 5;
            const int b = 20;

            //Pobranie wartosci podanej przez użytkownika 
            Console.Write("Podaj wartość ");
            int compare = Int32.Parse(Console.ReadLine());

            //Wykorzystanie instrukcji warunkowej IF z algebra bool'a
            if (compare >= a && compare <= b)
            {
                Console.WriteLine($"Twoja liczba {compare} mieści się w przedziale <{a},{b}>");
            }
            else
            {
                Console.WriteLine($"Twoja liczba {compare} nie mieści się w przedziale <{a},{b}>");
            }

        }
        static void QuestFive()
        {
            //Zad. 5.
            //Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest spoza zakresu
            //<5; 20>. Wypisz wynik w konsoli.

            // Deklaracja stałych zmiennych typu całkowitoliczbowego do porównania czy podana liczba 
            // mieści się w zdeklarowanym zakresie <5:20>
            const int a = 5;
            const int b = 20;

            //Pobranie wartosci podanej przez użytkownika 
            Console.Write("Podaj wartość ");
            int compare = Int32.Parse(Console.ReadLine());

            //Wykorzystanie instrukcji warunkowej IF z algebra bool'a
            if (compare >= a && compare <= b)
            {
                Console.WriteLine($"Twoja liczba {compare} mieści się w przedziale <{a},{b}>");
            }
            else
            {
                Console.WriteLine($"Twoja liczba {compare} nie mieści się w przedziale <{a},{b}>");
            }
        }
        static void QuestSix()
        {
            //Zad. 6.
            //Napisz program konsolowy, który pobierze z konsoli dwie liczby całkowite, po czym do trzeciej
            //zmiennej przypisze większą wartość.Wykorzystaj przypisanie warunkowe i wypisz wynik w konsoli.

            ////Wersja z funkcją warunkową if else
            //Console.WriteLine("Podaj pierwsza liczbe całkowitą");
            //int numberOne = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj druga liczbe całkowitą");
            //int numberTwo = Int32.Parse(Console.ReadLine());

            //int numberThree;
            //if (numberOne > numberTwo)
            //{
            //    numberThree = numberOne;
            //    Console.WriteLine($"Twoja liczba 1 ({numberOne}) jest wiekszą od 2giej liczby ({numberTwo})");
            //    Console.WriteLine($"Wynik zadeklarowanej trzeciej zmiennej = {numberThree}");
            //}
            //else if (numberOne < numberTwo)
            //{
            //    numberThree = numberTwo;
            //    Console.WriteLine($"Twoja liczba 1 ({numberOne}) jest mniejsza od 2giej liczby ({numberTwo})");
            //    Console.WriteLine($"Wynik zadeklarowanej trzeciej zmiennej = {numberThree}");
            //}
            //else
            //{
            //    numberThree = numberOne;
            //    Console.WriteLine("Wszystkie podane liczby są takie same");
            //    Console.WriteLine($"Wynik zadeklarowanej trzeciej zmiennej = {numberThree}");
            //}

            //Wersja z przypisaniem Warunkowym

            //Deklaracja dwóch zmiennych z drukowaniem tekstu na ekranie
            Console.WriteLine("Podaj pierwsza liczbe całkowitą");
            int numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe całkowitą");
            int numberTwo = Int32.Parse(Console.ReadLine());

            //Przypisanie najwiekszej wartości przez przypisanie Warunkowe, zwane również Operator warunkowy i oświadczenie if else
            int numberThree = (numberOne >= numberTwo) ? numberOne : numberTwo;
            Console.WriteLine($"Wynik zadeklarowanej trzeciej zmiennej = {numberThree}");

        }
        static void QuestSeven()
        {
            //Zad 7.
            //Napisz program konsolowy, który pobierze z konsoli długości trzech boków trójkąta. Sprawdź,
            //czy z podanych wartości można utworzyć trójkąt.Wypisz wynik w konsoli. 

            //Deklaracja trzech zmiennych z drukowaniem tekstu na ekranie
            Console.WriteLine("Podaj pierwsza liczbe całkowitą");
            int numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe całkowitą");
            int numberTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe całkowitą");
            int numberThree = Int32.Parse(Console.ReadLine());

            //Wersja z wykorzystaniem funkcji if else z zagnieżdzeniem
            if (numberOne + numberTwo > numberThree)
            {
                if (numberOne + numberThree > numberTwo)
                {
                    if (numberTwo + numberThree > numberOne)
                    {
                        Console.WriteLine("Tak!! Z podanych wartości możesz utworzyć trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych wartości nie można utworzyć trójkąta");
                    }
                }
                else
                {
                    Console.WriteLine("Z podanych wartości nie można utworzyć trójkąta");
                }
            }
            else
            {
                Console.WriteLine("Z podanych wartości nie można utworzyć trójkąta");
            }

            ////Wersja z wykorzystaniem licznika i funkcji if bez zagnieżdzenia

            ////zmienna pomocnicza, która jeśli równianie jest prawdziwe zwiększa swoją wartość o 1 
            //int counterTriangle = 0;

            //if (numberOne + numberTwo > numberThree)
            //{
            //    counterTriangle++;
            //}
            //if (numberOne + numberThree > numberTwo)
            //{
            //    counterTriangle++;
            //}
            //if (numberTwo + numberThree > numberOne)
            //{
            //    counterTriangle++;
            //}

            //if (counterTriangle == 3)
            //{
            //    Console.WriteLine("Tak!! Z podanych wartości możesz utworzyć trójkąt");
            //}
            //else
            //{
            //    Console.WriteLine("Z podanych wartości nie można utworzyć trójkąta");
            //}

        }
        static void QuestEight()
        {
            //Zad. 8.
            //Napisz program konsolowy, który pobierze dwie wartości z konsoli. Wyświetl w konsoli wyniki
            //dodawania, odejmowania, mnożenia oraz dzielenia.Pamiętaj, żeby przy próbie dzielenia przez 0
            //wyświetlić odpowiedni komunikat, który uniemożliwi przeprowadzenie „zakazanego” działania.Użyj
            //typu danych double. 

            // Pobieranie wartości od użytkownika 
            Console.Write("Podaj pierwsza liczbe ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Podaj pierwsza liczbe ");
            double numberTwo = double.Parse(Console.ReadLine());

            // Dodawanie
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");

            // Odejmowanie 
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");

            // Mnożenie
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");

            // Dzielenie
            if (numberTwo == 0)
            {
                Console.WriteLine("Pamiętaj cholero nie dziel przez 0");
            }
            else
            {
                Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}\n");
            }

        }
    }
}
