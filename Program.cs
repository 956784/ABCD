using System;
using System.IO;

class P
{
    static void Main(string[] args)
    {

        string f = "C:\\Users\\Admin\\Desktop\\fl.txt";

        try
        {
            string c = File.ReadAllText(f);
            int m = GetMaxPairs(c);
            Console.WriteLine("подряд ABCD = " + m);
        }
        catch (Exception e)
        {
            Console.WriteLine("ошибка: " + e.Message);
        }
    }

    static int GetMaxPairs(string c)
    {
        int m = 0;
        int cp = 0;

        for (int i = 0; i < c.Length - 1; i++)
        {
            string p = c.Substring(i, 2);

            if (p == "AB" || p == "CB")
            {
                cp++;
                i++;
            }
            else
            {
                m = Math.Max(m, cp);
                cp = 0;
            }
        }

        m = Math.Max(m, cp);

        return m;
    }
}