using System;

namespace TaskFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// Metoda wywołująca zadanie 1
            //QuestOne();
            //// Metoda wywołująca zadanie 2
            //QuestTwo();
            //// Metoda wywołująca zadanie 3
            //QuestThree();
            //// Metoda wywołująca zadanie 4        ------------- 
            //// Metoda wywołująca zadanie 5
            //QuestFive();
            //// Metoda wywołująca zadanie 6
            //QuestSix();
            //// Metoda wywołująca zadanie 7
            //QUestSeven();
            //// Metoda wywołująca zadanie 8
            //QuestEight();
            //// Metoda wywołująca zadanie 9
            //QuestNine();
            //// Metoda wywołująca zadanie 10
            //QuestTen();
            //// Metoda wywołująca zadanie 11
            //QuestEleven();
            //// Metoda wywołująca zadanie 12
            //QuestTwelve();
            //// Metoda wywołująca zadanie 13
            //QuestThirteen();
            //// Metoda wywołująca zadanie 14
            //QuestFourteen();
            //// Metoda wywołująca zadanie 15
            //QuestFifteen();
            //// Metoda wywołująca zadanie 16
            QuestSixteen();
        }
        public static void QuestOne()
        {
            //Zad. 1.
            //Napisz program, który wypisze liczby od 0 do podanej przez użytkownika.Pamiętaj o
            //zachowaniu odpowiednich odstępów pomiędzy poszczególnymi liczbami.

            //Strzelam ze w zadaniu chodzi o przeskok 1.

            Console.WriteLine("Podaj liczbe końcowa");
            int number = int.Parse(Console.ReadLine());

            // Wykorzystanie petli for
            for (int i = 0; i <= number; i++)
            {
                Console.Write($"{i} ");
            }
        }
        public static void QuestTwo()
        {
            //zad. 2.
            //Zmodyfikuj poprzedni program tak, żeby tym razem użytkownik mógł wybrać także
            //liczbę początkową. Zwróć uwagę, czy wypisane są także liczby graniczne.

            Console.WriteLine("Podaj liczbe początkową");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe końcową");
            int endNumber = int.Parse(Console.ReadLine());

            // petla for
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i} ");
            }
        }
        public static void QuestThree()
        {
            //zad. 3.
            //Zmodyfikuj program z zad. 1.tak, żeby zamiast wypisywać liczby od 0, zaczął odliczać
            //od liczby podanej przez użytkownika do zera.

            Console.WriteLine("Podaj liczbe końcowa");
            int number = int.Parse(Console.ReadLine());

            // Wykorzystanie petli for
            for (int i = number; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }

        }
        public static void QuestFive()
        {
            Console.WriteLine("\tTabliczka mnożenia");
            Console.WriteLine("----------------------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Dla {i} = ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void QuestSix()
        {
            Console.WriteLine("Podaj do jakiej liczby ma wyświetlić się tabliczka mnożenia");
            int numberChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("\tTabliczka mnożenia");
            Console.WriteLine("----------------------------------");

            for (int i = 1; i <= numberChoice; i++)
            {
                Console.Write($"Dla {i} = ");
                for (int j = 1; j <= numberChoice; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

        }
        public static void QUestSeven()
        {
            //zad. 7.
            //Napisz program, który wypisze w konsoli tylko liczby parzyste z zakresu od 0 do 100

            //// Wersja easy
            //for (int i = 0; i <= 100; i = i+2)
            //{
            //    Console.Write(i + " ");
            //}

            // Wersja z modulo
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void QuestEight()
        {
            //zad. 8.
            //Napisz program, który wypisze w konsoli tylko liczby nieparzyste z zakresu od 0 do 100.

            ////Wersja easy
            //for (int i = 1; i <= 100; i=i+2)
            //{
            //    Console.Write(i + " ");
            //}

            //Wersja z modulo bardziej uniwersalna!
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void QuestNine()
        {
            //zad. 9.
            //Napisz program, w którym użytkownik będzie mógł wybrać, czy chce wypisać liczby
            //parzyste czy nieparzyste, z zakresu podanego przez użytkownika.

            Console.WriteLine("Podaj prosze przedział początkowy");
            int startRange = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj prosze przedział końcowy");
            int endRange = int.Parse(Console.ReadLine());

            //Wybór parzyste czy nieparzyste 
            Console.Write("Prosze Wybrać czy maja wyświetlić się liczby 1. parzyste, 2. nieparzyste ");
            int menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                for (int i = startRange; i <= endRange; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (menuChoice == 2)
            {
                for (int i = startRange; i <= endRange; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono niewłaściwy parametr");
            }
        }
        public static void QuestTen()
        {
            Console.Write("Prosze podać początkowy zakres =");
            int startRange = int.Parse(Console.ReadLine());
            Console.Write("Prosze podać końcowy zakres =");
            int endRange = int.Parse(Console.ReadLine());

            // Wykorzystanie wcześniej przygotowanej metody do wyświetlania wyników
            //Podzielne przez 2
            LoopDivisorModulo(2, startRange, endRange);
            //Podzielne przez 3
            LoopDivisorModulo(3, startRange, endRange);
            //Podzielne przez 4
            LoopDivisorModulo(4, startRange, endRange);
            //Podzielne przez 5
            LoopDivisorModulo(5, startRange, endRange);
            //Podzielne przez 7
            LoopDivisorModulo(7, startRange, endRange);
            //Podzielne przez 9
            LoopDivisorModulo(9, startRange, endRange);
        }
        public static void QuestEleven()
        {
            Console.Write("Prosze podać początkowy zakres = ");
            int startRange = int.Parse(Console.ReadLine());
            Console.Write("Prosze podać końcowy zakres = ");
            int endRange = int.Parse(Console.ReadLine());
            Console.Write("Prosze podać dzielnik = ");
            int divisor = int.Parse(Console.ReadLine());

            LoopDivisorModulo(divisor, startRange, endRange);

        }
        public static void QuestTwelve()
        {
            //zad. 12.
            //Napisz program, który będzie wypisywał wszystkie liczby pierwsze z przedziału od 0
            //do liczby podanej przez użytkownika.

            // Ku przypomnieniu 
            // Liczba pierwsza – liczba naturalna większa od 1, która ma dokładnie dwa dzielniki
            // naturalne: jedynkę i siebie samą.

            // Wykorzystam tutaj dwie petle for. Pierwsza bedzie odpoweidzialna za przeszukiwanie zakresu podanego przez
            // użyktownika <2 do x>, druga bedzie dzielnikiem i bedzie sprawdzać w petli if czy liczba ma reszte z dzielenia.
            // Jako że liczba pierwsza ma tylko dwa dzielniki (jedynke pomijam bo zaczynam od 2) to licznik jesli przekroczy wartosc 1
            // zakończy petle. Zaoszczedzi to niepotrzebnych operacji i troche przyspieszy program.

            Console.Write("Prosze podać końcowy zakres = ");
            int endRange = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endRange; i++)
            {
                int divisorFlag = 0;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorFlag++;
                    }
                    if (divisorFlag > 1)
                    {
                        break;
                    }
                }
                if (divisorFlag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void QuestThirteen()
        {
            //zad. 13.
            //Zmodyfikuj poprzedni program tak, żeby użytkownik mógł podać zakres liczb.

            Console.Write("Prosze podać początkowy zakres = ");
            int startRange = int.Parse(Console.ReadLine());

            //petla while która wymusza od użytkownika aby zakres startowy był większy od 2
            while (startRange < 2)
            {
                Console.Write("Prosze podać zakres początkowy większy od 2 = ");
                startRange = int.Parse(Console.ReadLine());
            }
            Console.Write("Prosze podać końcowy zakres = ");
            int endRange = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endRange; i++)
            {
                int divisorFlag = 0;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorFlag++;
                    }
                    if (divisorFlag > 1)
                    {
                        break;
                    }
                }
                if (divisorFlag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void QuestFourteen()
        {
            //zad. 14.
            //Zmodyfikuj program Kalkulator tak, żeby po zakończeniu obliczeń pytał użytkownika,
            //czy chce kontynuować obliczenia bez wychodzenia z programu. Użytkownik za każdym razem
            //ma podawać liczby, na których chce działać i wybrać działanie.

            int loopChoice;
            do
            {
                // Pobieranie wartości od użytkownika 
                Console.Write("Podaj pierwsza liczbe ");
                int numberOne = int.Parse(Console.ReadLine());
                Console.Write("Podaj pierwsza liczbe ");
                int numberTwo = int.Parse(Console.ReadLine());

                // Wybór użytkownika
                Console.WriteLine("Wybierz z swoje działanie w kalkulatorze");
                Console.WriteLine("1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie");
                int menuChoice = int.Parse(Console.ReadLine());

                //Logika kalkulatora z switchem
                switch (menuChoice)
                {
                    case 1:
                        // Dodawanie
                        Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
                        break;
                    case 2:
                        // Odejmowanie
                        Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
                        break;
                    case 3:
                        // Mnożenie
                        Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
                        break;
                    case 4:
                        if (numberTwo == 0)
                        {
                            // Warunek saprawdzający dzy aby dzielnik nie jest 0
                            Console.WriteLine("Pamiętaj cholero, nie dziel przez 0!");
                        }
                        else
                        {
                            // Dzielenie
                            Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / (double)numberTwo}");
                        }
                        break;
                    default:
                        Console.WriteLine("Twój wybór jest nie zrozumiały.");
                        break;
                }

                Console.WriteLine("Czy chcesz rozpocząć od nowa?");
                Console.WriteLine("1. Tak, 2. Nie");
                loopChoice = int.Parse(Console.ReadLine());

                // Petla zabezpieczająca aby użytkownik wybrał opcje 1 lub 2.
                while (loopChoice != 1 && loopChoice != 2)
                {
                    Console.WriteLine("Podałeś błedna Cyfre wyboru?");
                    Console.WriteLine("1. Tak, 2. Nie");
                    loopChoice = int.Parse(Console.ReadLine());
                }
            } while (loopChoice != 2);

        }
        public static void QuestFifteen()
        {
            //zad. 16.
            //Napisz program, który będzie w konsoli za pomocą gwiazdek(*) rysował kwadrat o
            //długości boku podanej przez użytkownika(długość boku = ilość gwiazdek). Pamiętaj o dodaniu
            //odpowiednich odstępów pomiędzy gwiazdkami.

            Console.WriteLine("Podaj długośc boku kwadratu");
            int numberA = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberA; i++)
            {
                for (int j = 0; j < numberA; j++)
                {
                    if (j > 0 && j < numberA - 1 && i > 0 && i < numberA - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void QuestSixteen()
        {
            //zad. 16.
            //Zmodyfikuj poprzedni program tak, żeby rysował prostokąt o podanej długości boków.

            Console.WriteLine("Podaj długośc boku a prostokąta");
            int numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długośc boku b prostokąta");
            int numberB = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberB; i++)
            {
                for (int j = 0; j < numberA; j++)
                {
                    if (j > 0 && j < numberA - 1 && i > 0 && i < numberB - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        //Metoda Wyświetlająca liczby podzielne podane przez użytkownika
        public static void LoopDivisorModulo(int divisor, int startRange, int endRange)
        {

            Console.WriteLine($"Liczby podzielne przez {divisor} w zakresie <{startRange},{endRange}> ");

            for (int i = startRange; i <= endRange; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
