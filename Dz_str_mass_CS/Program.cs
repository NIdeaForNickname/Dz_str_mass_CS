namespace Dz_str_mass_CS;

class Program
{
    static void Main(string[] args)
    {
        // Part1();
        // Console.WriteLine("Press any key to continue...");
        // Console.ReadKey();
        // Part2();
        // Console.WriteLine("Press any key to continue...");
        // Console.ReadKey();
        Console.WriteLine(Part3());
    }   
    
    static void Part1()
    {
        // 1, 11, 21, 1211, 111221, 312211
        string a = "1", b;
        int repeats = 6, x;
        char temp;

        for (int i = 0; i < repeats; i++)
        {
            temp = a[0];
            b = "";
            x = 0;
            foreach (var ch in a)
            {
                if (ch == temp)
                {
                    x++;
                }
                else
                {
                    b += x;
                    b += temp;
                    temp = ch;
                    x = 1;
                }
            }
            b += x;
            b += temp;
            a = b;
            Console.WriteLine(b);
        }
    }

    static void Part2()
    {
        int size = 9;
        int[,,] cube = new int[size, size, size];
        double subx, suby, subz;

        for (int z = 0; z < size; z++)
        {
            subz = z - ((double)(size - 1) / 2);
            for (int y = 0; y < size; y++)
            {
                suby = y - ((double)(size - 1) / 2);
                for (int x = 0; x < size; x++)
                {
                    subx = x - ((double)(size - 1) / 2);
                    if (Math.Sqrt((subz * subz) + (suby * suby) + (subx * subx)) <= (double)size/2)
                    {
                        cube[z, y, x] = 1;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write("{0} ", cube[z, y, x]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    static bool Part3()
    {
        Console.WriteLine("Enter the sentence");
        string sentence = Console.ReadLine();
        string a = new string(sentence.Where(c => (!char.IsPunctuation(c) && c != ' ')).ToArray());
        a = a.ToLower();
        for (int i = 0; i < a.Length / 2; i++)
        {
            if (a[i] != a[a.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}