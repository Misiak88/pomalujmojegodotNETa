using System;

namespace TaskThree
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Metoda z rozwiazaniem do zadania 1 
            QuestFirst();
            //Metoda z rozwiazaniem do zadania 2 
            QuestTwo();
            //Metoda z rozwiazaniem do zadania 3
            QuestThree();
            //Metoda z rozwiazaniem do zadania 4
            QuestFour();
            //Metoda z rozwiazaniem do zadania 5
            QuestFive();
            //Metoda z rozwiazaniem do zadania 7
            QuestSeven();
            //Metoda z rozwiazaniem do zadania 8
            QuestEight();
        }
        public static void QuestFirst()
        {
            //Napisz kalkulator, w którym użytkownik poda dwie liczby, a następnie wybierze działanie, które
            //chce wykonać(1.Dodawanie, 2.Odejmowanie, 3.Mnożenie, 4.Dzielenie) i otrzyma w konsoli gotowy
            //wynik.Przy konstruowaniu logiki menu wyboru działania zastosuj konstrukcję if…else, którą zagęścisz
            //(warunek w warunku). Pamiętaj cholero, nie dziel przez 0! Co, jeśli użytkownik poda działanie
            //nieprawidłowo ?

            // Pobieranie wartości od użytkownika 
            Console.Write("Podaj pierwsza liczbe ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Podaj pierwsza liczbe ");
            int numberTwo = int.Parse(Console.ReadLine());

            // Wybór użytkownika
            Console.WriteLine("Wybierz z swoje działanie w kalkulatorze");
            Console.WriteLine("1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie");
            int menuChoice = int.Parse(Console.ReadLine());

            // Logika kalkulatora 
            if (menuChoice == 1)
            {
                // Dodawanie
                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            }
            else
            {
                if (menuChoice == 2)
                {
                    // Odejmowanie
                    Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
                }
                else
                {
                    if (menuChoice == 3)
                    {
                        // Mnożenie
                        Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
                    }
                    else
                    {
                        if (menuChoice == 4)
                        {
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
                        }
                        else
                        {
                            Console.WriteLine("Twój wybór jest nie zrozumiały.");
                        }
                    }
                }
            }
        }
        public static void QuestTwo()
        {
            // Pobieranie wartości od użytkownika 
            Console.Write("Podaj pierwsza liczbe ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Podaj pierwsza liczbe ");
            int numberTwo = int.Parse(Console.ReadLine());

            // Logika kalkulatora 
            Console.WriteLine("Wybierz z swoje działanie w kalkulatorze");
            Console.WriteLine("1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                // Dodawanie
                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            }
            else if (menuChoice == 2)
            {
                // Odejmowanie
                Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
            }
            else if (menuChoice == 3)
            {
                // Mnożenie
                Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
            }
            else if (menuChoice == 4)
            {

                if (numberTwo == 0)
                {
                    // Warunek saprawdzający dzy aby dzielnik nie jest 0
                    Console.WriteLine("Pamiętaj cholero, nie dziel przez 0!");
                }
                else
                {
                    // Dzielenie
                    Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
                }
            }
        }
        public static void QuestThree()
        {
            //Zad. 3.
            // Wykonaj Zad. 1.wykorzystując tym razem blok switch…case. Która wersja programu Twoim
            //zdaniem jest czytelniejsza ?

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
        }
        public static void QuestFour()
        {
            //Utwórz 4 metody: dodawanie(Addition), odejmowanie(Substraction), mnożenie
            //(Multiplication), dzielenie(Division).Wykorzystaj je w kalkulatorze, z Zad. 2.bądź Zad. 3., którego zapis
            //jest Twoim zdaniem czytelniejszy. Jak bardzo skrócił się kod Twojego programu?

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
                    Addition(numberOne, numberTwo);
                    break;
                case 2:
                    // Odejmowanie
                    Substraction(numberOne, numberTwo);
                    break;
                case 3:
                    // Mnożenie
                    Multiplication(numberOne, numberTwo);
                    break;
                case 4:
                    Division(numberOne, numberTwo);
                    break;
                default:
                    Console.WriteLine("Twój wybór jest nie zrozumiały.");
                    break;
            }

        }
        public static void QuestFive()
        {
            //Zad. 5.
            //Utwórz jeszcze 3 metody: dzielenie z resztą, druga potęga, trzecia potęga(nazewnictwo wedle
            //uznania).Dodaj je do swojego kalkulatora. 

            // Pobieranie wartości od użytkownika 
            Console.Write("Podaj pierwsza liczbe ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Podaj pierwsza liczbe ");
            int numberTwo = int.Parse(Console.ReadLine());

            // Wybór użytkownika
            Console.WriteLine("Wybierz z swoje działanie w kalkulatorze");
            Console.WriteLine("1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie, 5. Reszta z dzielenia," +
                "6. Druga potęga, 7. Trzecia potęga");
            int menuChoice = int.Parse(Console.ReadLine());

            //Logika kalkulatora z switchem
            switch (menuChoice)
            {
                case 1:
                    // Dodawanie
                    Addition(numberOne, numberTwo);
                    break;
                case 2:
                    // Odejmowanie
                    Substraction(numberOne, numberTwo);
                    break;
                case 3:
                    // Mnożenie
                    Multiplication(numberOne, numberTwo);
                    break;
                // dzielenie
                case 4:
                    Division(numberOne, numberTwo);
                    break;
                // Reszta z dzielenia
                case 5:
                    RestDivision(numberOne, numberTwo);
                    break;
                // Potęga 2
                case 6:
                    PowerTwo(numberOne, numberTwo);
                    break;
                // Potęga 3
                case 7:
                    PowerTrhee(numberOne, numberTwo);
                    break;
                // Wynik dla innych wartosci niż podanych w opcjach menu
                default:
                    Console.WriteLine("Twój wybór jest nie zrozumiały.");
                    break;
            }

        }
        public static void QuestSeven()
        {
            //Zad. 7.
            //Napisz program, który będzie wypisywał pierwiastki równania kwadratowego o postaci
            //ax2 + bx + c = 0.           
            //a) niech użytkownik poda wartości liczb a, b i c
            //b) sprawdź, czy są pierwiastki, czy są jeden, czy dwa
            //c) wypisz rozwiązania równania kwadratowego w konsoli, a jeśli takowych brak - stosowny
            //komunikat.

            //Pobieranie danych od użytkownika
            Console.WriteLine("Twoje równanie ma postać ax^2 + bx + c");
            Console.WriteLine("Prosze podać a");
            int elementA = int.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać b");
            int elementB = int.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać c");
            int elementC = int.Parse(Console.ReadLine());

            //Obliczanie Delty
            double deltaResult = calculatingDelta(elementA, elementB, elementC);

            //Sprawdzanie za pomocą if czy posiada dwa, jeden czy zero pierwiastkow
            if (deltaResult > 0)
            {
                TwoElements(deltaResult, elementA, elementB);
            }
            else if (deltaResult == 0)
            {
                OneElement(elementA, elementB);
            }
            else
            {
                NoneElements();
            }

        }
        public static void QuestEight()
        {
            //Zad. 8.
            //Napisz program, który będzie liczył pole i obwód figury. Rozwiązując zadanie daj:
            //a) menu wyboru figury
            //b) możliwość podania długości boków, podstaw, promienia bądź wysokości w zależności od figury
            //c) wypisz wyniki w konsoli.
            //Napisz algorytmy dla: kwadratu, prostokąta, trójkąta, trapezu, koła, rombu i równoległoboku

            Console.WriteLine("Program policzy pole i obwód figury");
            Console.WriteLine("Prosze wybrać Figurę");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Kwadrat, 2. prostokąt, 3. trójkąt, 4. trapez, 5. koło, 6. romb, 7. równoległobok");
            int menuChoice = int.Parse(Console.ReadLine());

            // funckja switch menu
            switch (menuChoice)
            {
                case 1:
                    CalculatingSquare();
                    break;
                case 2:
                    CalculatingRectangle();
                    break;
                case 3:
                    CalculatingTriangle();
                    break;
                case 4:
                    CalculatingTrapeze();
                    break;
                case 5:
                    CalculatingCircle();
                    break;
                case 6:
                    CalculatingRhombus();
                    break;
                case 7:
                    CalculatingParallelogram();
                    break;

                default:
                    Console.WriteLine("Podałeś niewłaściwą wartość");
                    break;
            }
        }

        //Metoda odpowiedzialna za dodawanie
        public static void Addition(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        }
        //Metoda odowiedzialna za odejmowanie
        public static void Substraction(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
        }
        //Metoda odpowiedzialna za mnożenie
        public static void Multiplication(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
        }
        //Metoda odpoweidzialna za dzielenie
        public static void Division(int numberOne, int numberTwo)
        {
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
        }
        //Metoda odpoweidzialna za reszta z dzielenia
        public static void RestDivision(int numberOne, int numberTwo)
        {
            if (numberTwo == 0)
            {
                // Warunek saprawdzający dzy aby dzielnik nie jest 0
                Console.WriteLine("Pamiętaj cholero, nie dziel przez 0!");
            }
            else
            {
                //Wykorzystanie modulo do policzenia reszty z dzielenia
                int resaultRestDivision = numberOne % numberTwo;
                Console.WriteLine(resaultRestDivision);

            }
        }
        //Metoda Potegowania do 2giej potegi
        public static void PowerTwo(int numberOne, int numberTwo)
        {
            Console.WriteLine("Wybrałeś operacje druga potęga");
            Console.WriteLine("Wybierz liczbe na której ma zostać przeprowadzona operacja");
            Console.Write($"1. = {numberOne}, 2. = {numberTwo} ");
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine(numberOne * numberOne);
                    break;
                case 2:
                    Console.WriteLine(numberTwo * numberTwo);
                    break;
                default:
                    Console.WriteLine("Wybrałeś niepoprawny parametr");
                    break;
            }
        }
        //Metoda Potegowania do 3giej potegi
        public static void PowerTrhee(int numberOne, int numberTwo)
        {
            Console.WriteLine("Wybrałeś operacje trzecia potęga");
            Console.WriteLine("Wybierz liczbe na której ma zostać przeprowadzona operacja");
            Console.Write($"1. = {numberOne}, 2. = {numberTwo} ");
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine(numberOne * numberOne * numberOne);
                    break;
                case 2:
                    Console.WriteLine(numberTwo * numberTwo * numberTwo);
                    break;
                default:
                    Console.WriteLine("Wybrałeś niepoprawny parametr");
                    break;
            }
        }
        //Metoda liczenia delty
        public static double calculatingDelta(int a, int b, int c)
        {
            // Obliczenie delty z wzoru = b^2 - 4 * a * c
            double resultDelta = Math.Pow(b, 2) - 4 * a * c;
            // Obliczenie pierwiastka z delty sqrt(delta)
            double sqrtResultDelta = Math.Sqrt(resultDelta);
            // Wyswietlenie obliczonej delty na ekranie
            Console.WriteLine($"Twoja delta = {sqrtResultDelta}");

            return sqrtResultDelta;
        }
        //Obliczanie i wyświetlanie dwoch pierwiastkow delty
        public static void TwoElements(double delta, int a, int b)
        {
            // zmienna x1
            double elementOne = (-b + delta) / (2 * a);
            // zmienna x2
            double elementTwo = (-b - delta) / (2 * a);

            // Wyswietlanie wynikow na ekranie
            Console.WriteLine("Twoje równanie kwadratowe posiada dwa rozwiązania");
            Console.WriteLine($"x1 = {elementOne}, x2 = {elementTwo}");
        }
        //Obliczanie i wyświetlanie jednego pierwiastka delty
        public static void OneElement(int a, int b)
        {
            // zmienna x0
            double elementZero = (-b) / (2 * a);
            // drukowanie wynikow na ekranie
            Console.WriteLine("Twoje równanie kwadratowe posiada jedno rozwiązanie");
            Console.WriteLine($"x0 = {elementZero}");
        }
        //Wyświetlanie komunikatu o braku pierwiastkow delty
        public static void NoneElements()
        {
            // Drukowanie komunikatu na ekranie
            Console.WriteLine("Twoje rownanie nie posiada żadnych rozwiązań");
        }
        //Obliczanie obwodu i pola kwadratu oraz wydrukowanie na ekranie
        public static void CalculatingSquare()
        {
            Console.WriteLine("Prosze podać długość boku kwadratu");
            double elementA = double.Parse(Console.ReadLine());

            // Obwód kwadratu
            double perimeter = 4 * elementA;

            // Pole powierzchni kwadratu
            double surfaceArea = Math.Pow(elementA, 2);

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód kwadratu = {perimeter} a Pole powierzchni kwadratu = {surfaceArea}");
        }
        //Obliczanie obwodu i pola prostokątu oraz wydrukowanie na ekranie
        public static void CalculatingRectangle()
        {
            Console.WriteLine("Prosze podać długość boku a prostokąta");
            double elementA = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku b prostokąta");
            double elementB = double.Parse(Console.ReadLine());

            // Obwód kwadratu
            double perimeter = 2 * elementA + 2 * elementB;

            // Pole powierzchni kwadratu
            double surfaceArea = elementA * elementB;

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód prostokąta = {perimeter} a Pole powierzchni prostokata = {surfaceArea}");
        }
        //Obliczanie obwodu i pola trójkąta oraz wydrukowanie na ekranie
        public static void CalculatingTriangle()
        {
            Console.WriteLine("Prosze podać długość boku a trójkąta");
            double elementA = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku b trójkąta");
            double elementB = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku c trójkąta");
            double elementC = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku h trójkąta");
            double elementH = double.Parse(Console.ReadLine());

            // Obwód trójkąta
            double perimeter = elementA + elementB + elementC;

            // Pole powierzchni trójkąta
            double surfaceArea = 0.5 * elementA * elementH;

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód trójkąta = {perimeter} a Pole powierzchni trójkąta = {surfaceArea}");
        }
        //Obliczanie obwodu i pola trapezu oraz wydrukowanie na ekranie
        public static void CalculatingTrapeze()
        {
            Console.WriteLine("Prosze podać długość boku a trapezu");
            double elementA = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku b trapezu");
            double elementB = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku c trapezu");
            double elementC = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku d trapezu");
            double elementD = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość boku h trapezu");
            double elementH = double.Parse(Console.ReadLine());

            // Obwód trapezu
            double perimeter = elementA + elementB + elementC + elementD;

            // Pole powierzchni trapezu
            double surfaceArea = ((elementA + elementB) * elementH) / 2;

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód trapezu = {perimeter} a Pole powierzchni trapezu = {surfaceArea}");
        }
        //Obliczanie obwodu i pola koła oraz wydrukowanie na ekranie
        public static void CalculatingCircle()
        {
            Console.WriteLine("Prosze podać długość promienia koła");
            double elementR = double.Parse(Console.ReadLine());

            // Obwód koła
            double perimeter = 2 * Math.PI * elementR;

            // Pole powierzchni koła
            double surfaceArea = Math.PI * Math.Pow(elementR, 2);

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód koła = {perimeter} a Pole powierzchni koła = {surfaceArea}");
        }
        //Obliczanie obwodu i pola rombu oraz wydrukowanie na ekranie
        public static void CalculatingRhombus()
        {
            Console.WriteLine("Prosze podać długość a boku rombu");
            double elementA = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać wysokość h rombu");
            double elementH = double.Parse(Console.ReadLine());

            // Obwód rombu
            double perimeter = 4 * elementA;

            // Pole powierzchni rombu
            double surfaceArea = elementA * elementH;

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód koła = {perimeter} a Pole powierzchni koła = {surfaceArea}");
        }
        //Obliczanie obwodu i pola równoległoboku oraz wydrukowanie na ekranie
        public static void CalculatingParallelogram()
        {
            Console.WriteLine("Prosze podać długość a boku równoległoboku");
            double elementA = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać długość b boku równoległoboku");
            double elementB = double.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać wysokość h równoległoboku");
            double elementH = double.Parse(Console.ReadLine());

            // Obwód rombu
            double perimeter = 2 * elementA + 2 * elementB;

            // Pole powierzchni rombu
            double surfaceArea = elementA * elementH;

            // Drukowanie wyników na ekranie
            Console.WriteLine($"Obwód równoległoboku = {perimeter} a Pole powierzchni równoległoboku = {surfaceArea}");
        }
    }
}
