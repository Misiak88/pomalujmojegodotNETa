using System;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Zadanie 1
            TaskOne();
            // Zadanie 2
            TaskTwo();
            // Zadanie 3
            TaskThree();
            // Zadanie 4
            TaskFour();
            // Zadanie 5
            TaskFive();
            // Zadanie 6
            TaskSix();

        }
        public static void TaskOne()
        {
            //Zad. 1.
            //Wypisz w konsoli swoje imię i nazwisko, wykorzystując w tym celu wszystkie znane Ci metody
            //wyświetlania komunikatów.Zastanów się, jak można wykorzystać ich wariacje.

            // Wykorzystanie Metody Console.Write(); drukowania na ekranie 
            Console.Write("Michal Kaminski\n");

            // Wykorzystanie Metody Drukowania Console.WriteLine(); na ekranie łańcucha znaków
            // Skrót w VS do Console.WriteLine(); --> cw + tab + tab
            Console.WriteLine("Michal Kaminski");

            // Wykorzystanie klasy string do przypisania calego lancucha znakow i wydrukowanie na ekranie
            string Name = "Michal Kaminski";
            Console.WriteLine(Name);

            // Wykorzystanie dwoch zmiennych klasy string i wydrukowanie na ekranie
            string LastName = "Kaminski", FirstName = "Michal";
            Console.WriteLine(FirstName + LastName);

            // Wykorzystanie dwoch zmiennych klasy string, dodanie miedzy nimi spacji i wydrukowanie na ekranie
            Console.WriteLine(FirstName + " " + LastName);

            // Przejscie do nastepnej lini
            Console.WriteLine();
        }
        public static void TaskTwo()
        {
            //Zad. 2.
            //Wyświetl w oknie konsoli cytat zamieszczony w zestawie 0. Wykorzystaj w tym celu metodę
            //Console.WriteLine(). Pamiętaj o zachowaniu rozmieszczenia wersów jeden pod drugim.

            //Przykład 1 
            // Wprowadzenie całego tekstu do Metody Console.Writeline();
            Console.WriteLine("\"Czemu ty się, zła godzino, \n" +
                "z niepotrzebnym mieszasz lękiem? \n" +
                "Jesteś - a więc musisz minąć. \n" +
                "Miniesz - a więc to jest piękne.\"\n" +
                "\t\t - Wisława Szymborska ");

            //Przykład 2 
            // Wykorzysztanie kilku metod Console.Writeline();
            Console.WriteLine("\"Czemu ty się, zła godzino,");
            Console.WriteLine("z niepotrzebnym mieszasz lękiem?");
            Console.WriteLine("Jesteś - a więc musisz minąć.");
            Console.WriteLine("Miniesz - a więc to jest piękne.\"");
            Console.WriteLine("\t\t - Wisława Szymborska");

            //Przykład 3
            // Wykorzystanie klasy string i wydrukowanie na ekranie
            string Text = "„Czemu ty się, zła godzino, \nz niepotrzebnym mieszasz lękiem? \nJesteś - a więc musisz minąć. \nMiniesz - a więc to jest piękne.”\n\t\t - Wisława Szymborska";
            Console.WriteLine(Text);

            //Przejscie do nastepnej linii
            Console.WriteLine();
        }
        public static void TaskThree()
        {
            //Zad. 3.
            //Wyświetl ten sam cytat, co w Zad. 2., tym razem korzystając tylko z metody Console.Write().
            //Pamiętaj o rozmieszczeniu wersów!

            //Drukowanie cytatu na ekranie za pomocą metody Console.Write()
            Console.Write("\"Czemu ty się, zła godzino, \n" +
                "z niepotrzebnym mieszasz lękiem? \n" +
                "Jesteś - a więc musisz minąć. \n" +
                "Miniesz - a więc to jest piękne.\"\n" +
                "\t\t - Wisława Szymborska ");

            //Przejscie do nastepnej linii
            Console.WriteLine("\n");
        }
        public static void TaskFour()
        {
            //Zad. 4.
            //Utwórz dwie zmienne liczbowe i przypisz im wartości. Wyświetl w konsoli wyniki dodawania,
            //odejmowania, mnożenia oraz dzielenia.Niech druga liczba nie będzie zerem. Użyj typu danych double.

            // Deklaracja dwóch zmiennych typu double
            double NumberOne = 10, NumberTwo = 33;

            // Dodawanie 
            Console.WriteLine(NumberOne + NumberTwo);

            // Odejmowanie
            Console.WriteLine(NumberOne - NumberTwo);

            // Mnożenie
            Console.WriteLine(NumberOne * NumberTwo);

            // Dzielenie
            Console.WriteLine(NumberOne / NumberTwo);

            // Przejscie do nastepnej linii 
            Console.WriteLine();
        }
        public static void TaskFive()
        {
            //Zad. 5.
            //Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę.Wyświetl w
            //konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia.Niech druga liczba nie będzie zerem.
            //Użyj typu danych double.

            //Pobieranie i przypisywanie pobranych danych do zmiennych typu dauble
            Console.Write("Podaj pierwsza liczbe ");
            double NumberOne = double.Parse(Console.ReadLine());
            Console.Write("Podaj druga liczbe ");
            double NumberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("\t\tWyniki" + "\n----------------------------------------");
            // Dodawanie 
            Console.WriteLine(NumberOne + NumberTwo);

            // Odejmowanie
            Console.WriteLine(NumberOne - NumberTwo);

            // Mnożenie
            Console.WriteLine(NumberOne * NumberTwo);

            // Dzielenie
            Console.WriteLine(NumberOne / NumberTwo);

            // Przejscie do nastepnej linii 
            Console.WriteLine();
        }
        public static void TaskSix()
        {
            //Zad. 6.
            //Utwórz dwie zmienne liczbowe typu double. Dla każdego z działań (dodawanie, odejmowanie,
            //mnożenie i dzielenie) przypisz z konsoli nowy zestaw liczb oraz wypisz ich wyniki w konsoli w formie
            //pełnych działań arytmetycznych($”{ }”).

            //Deklaracja dwoch zmiennych typu double
            double NumberOne = 10, NumberTwo = 33;

            Console.WriteLine("Wyniki działań arytmetycznych z zdeklarowanymi zmiennymi");
            Console.WriteLine("------------------------------------------------");
            // Dodawanie
            Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");

            // Odejmowanie 
            Console.WriteLine($"{NumberOne} - {NumberTwo} = {NumberOne - NumberTwo}");

            // Mnożenie
            Console.WriteLine($"{NumberOne} * {NumberTwo} = {NumberOne * NumberTwo}");

            // Dzielenie
            Console.WriteLine($"{NumberOne} / {NumberTwo} = {NumberOne / NumberTwo}\n");

            // Wprowadzanie nowych danych z klawiatury
            Console.WriteLine("Wprowadz pierwsza liczbe");
            NumberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz druga liczbe");
            NumberTwo = double.Parse(Console.ReadLine());

            //Drukowanie Wyników
            Console.WriteLine("\nWyniki działań arytmetycznych z zdeklarowanymi zmiennymi");
            Console.WriteLine("------------------------------------------------");
            // Dodawanie
            Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");

            // Odejmowanie 
            Console.WriteLine($"{NumberOne} - {NumberTwo} = {NumberOne - NumberTwo}");

            // Mnożenie
            Console.WriteLine($"{NumberOne} * {NumberTwo} = {NumberOne * NumberTwo}");

            // Dzielenie
            Console.WriteLine($"{NumberOne} / {NumberTwo} = {NumberOne / NumberTwo}\n");

        }
    }
}
