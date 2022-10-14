using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int[] freqs = Octave(6);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F6)
                {
                    freqs = Octave(6);
                    Console.WriteLine("шестая октава");
                }
                else if (key.Key == ConsoleKey.F7)
                {
                    freqs = Octave(7);
                    Console.WriteLine("седьмая октава");
                }
                else if (key.Key == ConsoleKey.F8)
                {
                    freqs = Octave(8);
                    Console.WriteLine("восьмая октава");
                }

                if (key.Key == ConsoleKey.A)
                {
                    Beep(freqs[0]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Beep(freqs[1]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Beep(freqs[2]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Beep(freqs[3]);
                    Console.Clear();

                }
                else if (key.Key == ConsoleKey.G)
                {
                    Beep(freqs[4]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Beep(freqs[5]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.J)
                {
                    Beep(freqs[6]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.K)
                {
                    Beep(freqs[7]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.L)
                {
                    Beep(freqs[8]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.V)
                {
                    Beep(freqs[9]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.B)
                {
                    Beep(freqs[10]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.N)
                {
                    Beep(freqs[11]);
                    Console.Clear();
                }
            }
            
        }

        static void Beep(int freq)
        {
            Console.Beep(freq, 500);
        }

        static int[] Octave(int octave)
        {
            int[] eight = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3137, 3322, 3520, 3729, 3951 };
            int[] seven = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] six = { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };

            if (octave == 8)
            {
                return eight;
            }
            else if (octave == 7)
            {
                return seven;
            }
            else if (octave == 6)
            {
                return six;
            }
            else
            {
                return null; 
            }
        }
    }
}
