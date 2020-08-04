using System;

namespace TastFive
{
    class Program
    {
        public static void Main(string[] args)
        {
            ////Metoda z rozwiazaniem do zadania 1 
            //QuestOne();
            ////Metoda z rozwiazaniem do zadania 2 
            //QuestTwo();
            ////Metoda z rozwiazaniem do zadania 3
            //QuestThree();
            ////Metoda z rozwiazaniem do zadania 4
            //QuestFour();
            ////Metoda z rozwiazaniem do zadania 5
            //QuestFive();
            ////Metoda z rozwiazaniem do zadania 6
            //QuestSix();
            ////Metoda z rozwiazaniem do zadania 7
            //QuestSeven();
            ////Metoda z rozwiazaniem do zadania 8
            //QuestEight();
            ////Metoda z rozwiazaniem do zadania 9
            //QuestNine();
            QuestTen();

        }
        public static void QuestOne()
        {
            //Zad. 1.
            //Napisz program, w którym:
            //a) utworzysz tablicę o wielkości 50
            //b) zapełnisz ją kolejnymi liczbami począwszy od 1
            //c) wyświetlisz w konsoli jej zawartość.

            // Zmienna typu stałego odpowiedzialna za określenie wielkości Tablicy
            const int sizeArray = 50;

            // a) Tworzenie tablicy o wielkości sizeArray = 50;
            int[] numberArray = new int[sizeArray];

            //// b.1) zapełnianie tablicy za pomocą petli for z wykorzystaniem stałej sizeArray
            //for (int i = 0; i < sizeArray; i++)
            //{
            //    numberArray[i] = i + 1;
            //}

            //// b.2) zapełnianie tablicy za pomocą petli for z wykorzystaniem funkcji Length która określa wielkośc tablicy
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = i + 1;
            }

            ////c.1) Wyświetlanie tablicy za pomoca petli forz wykorzystaniem stałej sizeArray
            //for (int i = 0; i < sizeArray; i++)
            //{
            //    Console.Write(numberArray[i] + " ");
            //}

            // c.2) Wyświetlanie tablicy za pomoca petli foreach
            foreach (int i in numberArray)
            {
                Console.Write(i + " ");
            }
        }
        public static void QuestTwo()
        {
            //Zad. 2.
            //Napisz program, w którym:
            //a) utworzysz tablicę o wielkości 20
            //b) zapełnisz ją wartościami pobranymi z konsoli
            //c) porównasz, czy:
            //                    a.element pierwszy jest mniejszy czy większy od ostatniego
            //                    b.element drugi jest różny od przedostatniego
            //d) wypiszesz wszystkie elementy tablicy.


            // Zmienna typu stałego odpowiedzialna za określenie wielkości Tablicy
            const int sizeArray = 20;

            // a) Tworzenie tablicy o wielkości sizeArray = 20;
            int[] numberArray = new int[sizeArray];

            //// b.1) Zapełnianie Tablicy elementami pobranymi z klawiatury z wykorzystaniem petli for
            //for (int i = 0; i < sizeArray; i++)
            //{
            //    Console.Write($"Twoja {i+1} liczba = ");
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //}

            //// b.2) zapełnianie tablicy za pomocą petli for z wykorzystaniem funkcji Length która określa wielkośc tablicy
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write($"Twoja {i + 1} liczba = ");
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            // c) porównanie elementów za pomoca funkcji warunkowej if
            if (numberArray[0] > numberArray[sizeArray - 1])
            {
                Console.WriteLine($"Liczba {sizeArray - (sizeArray - 1)} = {numberArray[0] }" +
                    $" zapisana w tablicy jest wieksza od ostatniej {sizeArray} = {numberArray[sizeArray - 1]}");
            }
            else if (numberArray[0] < numberArray[sizeArray - 1])
            {
                Console.WriteLine($"Liczba {sizeArray - (sizeArray - 1)} = {numberArray[0] }" +
                    $" zapisana w tablicy jest mniejsza od ostatniej {sizeArray} = {numberArray[sizeArray - 1]}");
            }
            else
            {
                Console.WriteLine($"Obie liczby są sobie równe i równaja się = {numberArray[0]}");
            }

            if (numberArray[1] != numberArray[sizeArray - 2])
            {
                Console.WriteLine($"Liczba {sizeArray - (sizeArray - 2)} = {numberArray[1] }" +
                    $" jest różna od przedostatniej {sizeArray - 1} = {numberArray[sizeArray - 2]}");
            }
            else
            {
                Console.WriteLine($"Obie liczby są sobie równe i równaja się = {numberArray[1]}");
            }

            //// d.1) Wydrukowanie wszystkich elementów tablicy z wykorzystaniem petli for
            //for (int i = 0; i < sizeArray; i++)
            //{
            //    Console.Write(numberArray[i] + " ");
            //}

            // d.2) Wydrukowanie wszystkich elementów tablicy z wykorzystaniem petli foreach
            foreach (int i in numberArray)
            {
                Console.Write(i + " ");
            }
        }
        public static void QuestThree()
        {
            //Zad. 3.
            //Napisz program, w którym:
            //a) utworzysz tablicę o wielkości 10
            //b) zapełnisz ją losowymi wartościami
            //c) wypiszesz w konsoli zawartość tej tablicy
            //d) sprawdzisz, jaka wartość w tablicy jest największa i pod jakim jest indeksem, po czym wypiszesz
            //obie dane w konsoli
            //e) sprawdzisz, jaka wartość w tablicy jest najmniejsza i pod jakim jest indeksem, po czym
            //wypiszesz obie dane w konsoli

            //W celu uzyskania wartości losowej nieujemnej, na początku metody, w której zamierzasz korzystać z
            //wartości losowych, umieść:
            //Random rand = new Random();
            //Dzięki temu możesz teraz stosując metodę Next() w obrębie danej metody pobierać wartości losowe:
            //Int val = rand.Next();
            //Każda metoda, w której będziesz korzystać z wartości losowych, musi mieć własną deklarację
            //dla rand.

            // Zmienna typu stałego odpowiedzialna za określenie wielkości Tablicy
            const int sizeArray = 10;

            // a) Tworzenie tablicy o wielkości sizeArray = 10;
            int[] numberArray = new int[sizeArray];

            // b) Zapełnianie Tablicy liczbami pseudolosowymi z wykorzystaniem wcześniej napisanej metody PseudorandomNumberGenerator()
            for (int i = 0; i < sizeArray; i++)
            {
                numberArray[i] = PseudorandomNumberGenerator(0, int.MaxValue);
            }

            // c) Drukowanie na ekranie wyników z zapisanymi liczbami pseudolosowymi
            foreach (int i in numberArray)
            {
                Console.Write(i + " ");
            }

            // d)
            // Zmienna typu int, przypisuje do niej pierwszą wartość zapisana w tablicy.
            int maxNumber = numberArray[0];

            // zmienna która będę przechowywać indeks najwiekszej liczby, ustawione na 0 ponieważ pobrałem 
            // najwieksza liczbe z pierwszego indeksu tablicy.
            int maxIndex = 0;

            //petla for z funkcja warunkową if która przeleci przez wszystkie wartości w tablicy, 
            // pętla rozpoczyna się od 1 ponieważ nie ma sensu porównywać tej samej wartości.
            for (int i = 1; i < sizeArray; i++)
            {
                if (maxNumber < numberArray[i])
                {
                    maxNumber = numberArray[i];
                    maxIndex = i;
                }
            }

            // Wyświetlenie najwiekszej liczby pod wskazanym indeksem;
            Console.WriteLine($"\nNajwieksza liczba jest pod indeksem {maxIndex} = {maxNumber}");

            // e) Tak samo jak w podpunkcie d)
            int minNumber = numberArray[0];
            int minIndex = 0;

            for (int i = 1; i < sizeArray; i++)
            {
                if (minNumber > numberArray[i])
                {
                    minNumber = numberArray[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"\nNajmniejsza liczba jest pod indeksem {minIndex} = {minNumber}");

        }
        public static void QuestFour()
        {
            //Zad. 4.
            //Napisz metodę, którą posortujesz tablicę z Zad. 3.Zastosuj algorytm sortowania bąbelkowego.

            // Zmienna typu stałego odpowiedzialna za określenie wielkości Tablicy
            const int sizeArray = 10;

            // a) Tworzenie tablicy o wielkości sizeArray = 10;
            int[] numberArray = new int[sizeArray];

            //// b) Zapełnianie Tablicy liczbami pseudolosowymi z wykorzystaniem wcześniej napisanej metody PseudorandomNumberGenerator()
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    numberArray[i] = PseudorandomNumberGenerator();
            //}

            // c) Sortowanie Bąbelkowe
            BubbleSort(numberArray);

            // d) Wydrukuj posortowana tablice
            ShowArray(numberArray);
        }
        public static void QuestFive()
        {
            //Napisz program, w którym:
            //a) utworzysz tablicę statyczną o wielkości 20
            //b) używając funkcji rand() i srand() zapełnisz ją losowymi wartościami
            //c) wypiszesz w konsoli zawartość tej tablicy
            //d) napiszesz funkcję, która będzie aktualizowała element tablicy o indeksie podanym przez
            //użytkownika na wartość również przez niego wybraną
            //e) wypisz w konsoli zaktualizowaną tablicę.
            //f) Pamiętaj, że użytkownik nie może odwoływać się poza zakres tablicy.

            int[] numberArray = new int[5];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = PseudorandomNumberGenerator(0, int.MaxValue);
            }

            ShowArray(numberArray);
            ReplaceArrayElement(numberArray);
            Console.WriteLine("\t\tTablica po zamianie \n" +
                "-------------------------------------------------");
            ShowArray(numberArray);
        }
        public static void QuestSix()
        {
            //Zad. 6.
            //Napisz program, w którym:
            //a) utworzysz tablicę dwuwymiarową o wymiarach 10x10
            //b) do każdego elementu tablicy wpiszesz wyniki tabliczki mnożenia od 1 do 10
            //c) wypiszesz zawartość tablicy w konsoli tak, żeby każdy wiersz tabeli odpowiadał oddzielnemu
            //wierszowi w konsoli. 

            int[,] superNumberArray = new int[10, 10];

            // Metoda GetLength(0) - odpowiedzialna jest za wielkosc kolumn
            for (int i = 0; i < superNumberArray.GetLength(0); i++)
            {
                // Metoda GetLength(1) - odpowiedzialna jest za wielkosc wierszy 
                for (int j = 0; j < superNumberArray.GetLength(1); j++)
                {
                    superNumberArray[i, j] = (i + 1) * (j + 1);
                }
            }

            // drukowanie tablicy dwuwymiarowej
            ShowArray2D(superNumberArray);
        }
        public static void QuestSeven()
        {
            //Zad. 7.
            //Potraktuj tablicę dwuwymiarową jako macierz kwadratową.
            //Napisz program, w którym:
            //a) stworzysz tablicę dwuwymiarową o rozmiarze 3x3
            //b) wypełnisz jej elementy liczbami z zakresu od 0 do 9
            //c) wypiszesz w konsoli otrzymaną macierz zachowując jej układ
            //d) przemnożysz tą macierz przez liczbę podaną przez użytkownika i wpiszesz ją w konsoli.
            //
            //
            //#UpolujDaniela

            int[,] superNumberArray = new int[3, 3];

            for (int i = 0; i < superNumberArray.GetLength(0); i++)
            {
                for (int j = 0; j < superNumberArray.GetLength(1); j++)
                {
                    superNumberArray[i, j] = PseudorandomNumberGenerator(0, 9);
                }
            }

            ShowArray2D(superNumberArray);

            Console.WriteLine("Porsze podać wartość Skalara");
            int valScalar = int.Parse(Console.ReadLine());

            MatrixMultiplicationScalar(superNumberArray, valScalar);

            ShowArray2D(superNumberArray);

        }
        public static void QuestEight()
        {
            //Zad. 8.
            //Potraktuj tablicę dwuwymiarową jako macierz kwadratową.
            //Napisz program, w którym:
            //a) stworzysz tablicę dwuwymiarową o rozmiarze 5x5
            //b) wypełnisz jej elementy liczbami z zakresu od 0 do 9
            //c) wypiszesz w konsoli otrzymaną macierz zachowując jej układ
            //d) obliczysz ślad otrzymanej macierzy i wypiszesz go w konsoli.

            int[,] superNumberArray = new int[5, 5];

            for (int i = 0; i < superNumberArray.GetLength(0); i++)
            {
                for (int j = 0; j < superNumberArray.GetLength(1); j++)
                {
                    superNumberArray[i, j] = PseudorandomNumberGenerator(0, 9);
                }
            }
            // Wydrukowanie Macierzy
            ShowArray2D(superNumberArray);
            // Policzenie śladu Macierzy i wydrukowanie
            MatrixTrace(superNumberArray);

        }
        public static void QuestNine()
        {
            //Zad. 9.
            //Potraktuj tablicę dwuwymiarową jako macierz kwadratową.
            //Napisz program, w którym:
            //a) stworzysz tablicę dwuwymiarową o rozmiarze 3x3
            //b) wypełnisz jej elementy liczbami z zakresu od 0 do 9
            //c) wypiszesz w konsoli otrzymaną macierz zachowując jej układ
            //d) obliczysz kwadrat tej macierzy i wypiszesz go w konsoli.

            int[,] superNumberArray = new int[3, 3];

            for (int i = 0; i < superNumberArray.GetLength(0); i++)
            {
                for (int j = 0; j < superNumberArray.GetLength(1); j++)
                {
                    superNumberArray[i, j] = PseudorandomNumberGenerator(0, 9);
                }
            }

            ShowArray2D(superNumberArray);
            MatrixPowTwo(superNumberArray);


        }
        public static void QuestTen()
        {
            //Zad. 10
            //Potraktuj tablicę dwuwymiarową jako macierz kwadratową.
            //Napisz program, w którym:
            //a) stworzysz dwie tablice dwuwymiarowe o rozmiarze 3x3
            //b) wypełnisz ich elementy liczbami z zakresu od 0 do 9
            //c) wypiszesz w konsoli otrzymane macierze, zachowując ich układ
            //d) przemnożysz ze sobą macierze pierwszą z drugą i drugą z pierwszą i wypiszesz otrzymane
            //macierze w konsoli.

            int[,] superNumberArrayOne = new int[3, 3];
            int[,] superNumberArrayTwo = new int[3, 3];

            for (int i = 0; i < superNumberArrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < superNumberArrayOne.GetLength(1); j++)
                {
                    superNumberArrayOne[i, j] = PseudorandomNumberGenerator(0, 9);
                    superNumberArrayTwo[i,j] = PseudorandomNumberGenerator(0, 9);
                }
            }
            Console.WriteLine("Macierz A");
            ShowArray2D(superNumberArrayOne);
            Console.WriteLine("Macierz B");
            ShowArray2D(superNumberArrayTwo);

            MatrixMultiplicationMatrix(superNumberArrayOne, superNumberArrayTwo, "A x B");
            MatrixMultiplicationMatrix(superNumberArrayTwo, superNumberArrayOne, "B x A");
        }



        //Generator liczb pseudolosowych
        public static int PseudorandomNumberGenerator(int minVaule, int maxVaule)
        {

            Random rand = new Random();
            int PseudorandomNumber = rand.Next(minVaule, maxVaule);


            return PseudorandomNumber;
        }
        //Algorytm sortowania bąbelkowego
        public static void BubbleSort(int[] array)
        {
            // Jako że metoda ma być jak najbardzie uniwersalna, wykorzystuje funckje length aby zapisała w zmiennej 
            // arrLength wielkość tablicy
            int arrLength = array.Length;

            // zmienna typu bool, do while bedzie sprawdzała warunek czy przebiega sortowania, jeśli nie 
            // przyjmie wartość negatywną i zakończy pętle a tablica bedzie poukładana.
            bool sortFlag;
            do
            {
                // Przy każdyn rozpoczęciu pętli ustawiam sortFlag = true;
                sortFlag = false;

                // Petla for odpoweidzialna za poruszanie sie po tablicy od 0 indeksu
                // Żeby nie wyść poza zakres Tablicy, działać będziemy do arrLength - 1
                for (int i = 0; i < arrLength - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // instrukcja warunkowa sprawdziła że są niepoukładane liczby, zmieniam flage na true 
                        sortFlag = true;

                        // Zamiana elementów z wykorzystaniem schowka aktualnego z nastepnym indeksem.
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }

            } while (sortFlag != false);
        }
        //Drukowanie Tablicy jednowymiarowej na ekranie
        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        //Aktualizowanie tablicy przez użytkownika
        public static void ReplaceArrayElement(int[] array)
        {
            int maxArrayValue = array.Length;

            Console.WriteLine($"\nIlość elementów w tablicy {array.Length}" +
                $" Indeksy zaczynają się od 0 do {array.Length - 1}");
            Console.WriteLine("\nPodaj numer indeksu tablicy który chcesz zmienić");
            int userTypeArrayIndex = int.Parse(Console.ReadLine());

            while (userTypeArrayIndex < 0 || userTypeArrayIndex >= maxArrayValue)
            {
                Console.WriteLine("!!!Podałeś nie właściwy indeks!!! \nProszę podać właściwy numer indeksu");
                userTypeArrayIndex = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Prosze o podanie nowej wartosci całkowitej która " +
                $"zostanie zapisana w tablicy o indeksie {userTypeArrayIndex}");
            int userTypeArrayVaule = int.Parse(Console.ReadLine());

            array[userTypeArrayIndex] = userTypeArrayVaule;
        }
        //Drukowanie Tablicy dwuwymiarowej na ektanie
        public static void ShowArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Mnożenie macierzy przez skalar
        public static void MatrixMultiplicationScalar(int[,] array, int valScalar)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] *= valScalar;
                }
            }
        }
        // Suma głównej przekątnej tablicy dwuwymiarowej czyli Ślad macierzy
        public static void MatrixTrace(int[,] array)
        {
            // Licznik sumy przekątnej
            int traceSum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                traceSum += array[i, i];
            }

            Console.WriteLine($"Śladz macierzy, tr = {traceSum}");
        }
        // Obliczanie kwadratu macierzy
        public static void MatrixPowTwo(int[,] array)
        {

            Console.WriteLine("\n\tMacierz podniesiony do kwadratu");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int tempVal = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        tempVal += (array[i, k] * array[k, j]);
                    }
                    Console.Write(tempVal + " ");
                }
                Console.WriteLine();
            }
        }
        // Mnożenie Macierzy z drukowaniem na ekranie
        public static void MatrixMultiplicationMatrix(int[,] arrayOne, int[,] arrayTwo, string text)
        {
            Console.WriteLine($"\tWynik mnożenia Macierza {text}");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    int tempVal = 0;
                    for (int k = 0; k < arrayOne.GetLength(1); k++)
                    {
                        tempVal += (arrayOne[i, k] * arrayTwo[k, j]);
                    }
                    Console.Write(tempVal + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
