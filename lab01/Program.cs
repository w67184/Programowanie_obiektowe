using System.Threading.Channels;
using System.Xml.Schema;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        ViewMenu:
            Console.WriteLine("=================== 1. Zadanie 1. ===================\n");
            Console.WriteLine("===================Kalkulator===================");
            Console.WriteLine("=================== 2. Suma ===================");
            Console.WriteLine("=================== 3. Różnica ===================");
            Console.WriteLine("=================== 4. Iloczyn ===================");
            Console.WriteLine("=================== 5. Iloraz ===================");
            Console.WriteLine("=================== 6. Potęga ===================");
            Console.WriteLine("=================== 7. Pierwiastek ===================");
            Console.WriteLine("=================== 8. Funkcje trygonomatryczne dla zadanego kąta ===================\n");
            Console.WriteLine("=================== 9. Zadanie 3 ===================");
            Console.WriteLine("=================== 10. Zadanie 4 ===================");
            Console.WriteLine("=================== 11. Zadanie 5 ===================");
            Console.WriteLine("=================== 12. Zadanie 6 ===================");
            Console.WriteLine("=================== 13. Zadanie 7 ===================");
            Console.WriteLine("=================== 14. Wyjście ===================");
            Console.WriteLine("Twój wybór: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 2:
                    Suma();
                    break;
                case 3:
                    Roznica();
                    break;
                case 4:
                    Iloczyn();
                    break;
                case 5:
                    Iloraz();
                    break;
                case 6:
                    Potega();
                    break;
                case 7:
                    Pierwiastek();
                    break;
                case 8:
                    Trygonomatria();
                    break;
                case 1:
                    Zadanie1();
                    break;
                case 9:
                    Zadanie3();
                    break;
                case 10:
                    Tablica2();
                    break;
                case 11:
                    Zadanie5();
                    break;
                case 12:
                    Zadanie6();
                    break;
                case 13:
                    Zadanie7();
                    break;
                case 14:
                    Zamknij();
                    break;
                default:
                    Console.WriteLine("Błędny wybór, spróbuj ponownie\n");
                    goto ViewMenu;
            }
        }
        static void Zamknij()
        {
            System.Environment.Exit(1);
        }
        static void Suma()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nSuma: {a + b}");

        }
        static void Roznica()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nRóżnica: {a - b}");
        }
        static void Iloczyn()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nIloczyn: {a * b}");
        }
        static void Iloraz()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0");
            }
            else
            {
                Console.WriteLine($"\nIloraz: {a / b}");
            }
        }
        static void Potega()
        {
            double a, b;
            a = DoubleInput('A');
            b = DoubleInput('B');
            Console.WriteLine($"\nSuma: {Math.Pow(a, b)}");
        }
        static void Pierwiastek()
        {
            double a = DoubleInput('A');
            Console.WriteLine($"\nSuma: {Math.Sqrt(a)}");
        }
        static void Trygonomatria()
        {
            double a = DoubleInput('A');
            double radiany = (a * Math.PI) / 180;
            Console.WriteLine("Cosinus " + a + ": " + Math.Cos(radiany));
            Console.WriteLine("Sinus " + a + ": " + Math.Sin(radiany));
            Console.WriteLine("Tangens " + a + ": " + Math.Tan(radiany));
            Console.WriteLine("Cotangens " + a + ": " + 1 / Math.Tan(radiany));
        }



        static void Zadanie1()
        {
            double a = DoubleInput('a');
            double b = DoubleInput('b');
            double c = DoubleInput('c');
            double delta, x1, x2;
            if (a == b)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
            }
            else
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiązań w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine(x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
                }

            }
        }
        static double DoubleInput(char n)
        {
            Console.WriteLine("Podaj wartość " + n + ": ");
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

        static void Zadanie3()
        {
            int[] tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Podaj liczbę: ({i + 1}/10)");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            string asc = String.Join(", ", tab);

            int[] newTab = (int[])tab.Clone();
            Array.Reverse(newTab);
            string desc = String.Join(", ", newTab);

            string odd = "";
            string even = "";
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += tab[i];
                }
                else
                {
                    odd += tab[i];
                }
            }

            bool menu = true;
            do
            {
                Console.WriteLine($"Wybierz co chcesz wyświetlić: (1 - 5)");
                Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu.\n2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu.\n3. Wyświetlanie elementów o nieparzystych indeksach.\n4. Wyświetlanie elementów o parzystych indeksach.\n5. Wyjście.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine(asc);
                }
                else if (userInput == 2)
                {
                    Console.WriteLine(desc);
                }
                else if (userInput == 3)
                {
                    Console.WriteLine(odd);
                }
                else if (userInput == 4)
                {
                    Console.WriteLine(even);
                }
                else
                {
                    menu = false;
                }
            } while (menu);
        }
        static void Tablica2()
        {
            double[] arr = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Podaj liczbę: ({i + 1}/10)");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double suma = 0;
            double iloczyn = 1;
            double srednia = 0;
            double min = 0;
            double max = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += arr[i];
                iloczyn *= arr[i];
            }
            srednia = suma / arr.Length;
            min = arr.Min();
            max = arr.Max();

            Console.WriteLine($"Suma: {suma}\nIloczyn: {iloczyn}\nŚrednia: {srednia}\nWartość minimalna: {min}\nWartość maksymalna: {max}");
        }
        static void Zadanie5()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19) continue;
                Console.WriteLine(i);
            }
        }
        static void Zadanie6()
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0) break;
            }
        }
        static void Zadanie7()
        {
            Console.WriteLine("Podaj liczbę elementów do posortowania:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Podaj liczby do posortowania:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Wybierz rodzaj sortowania:");
            Console.WriteLine("1. Sortowanie bąbelkowe");
            Console.WriteLine("2. Sortowanie przez wstawianie");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BubbleSort(arr);
                    break;

                case 2:
                    InsertionSort(arr);
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór");
                    break;
            }

            Console.WriteLine("Posortowane liczby:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}