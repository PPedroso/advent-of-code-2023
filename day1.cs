using System;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

public static class Day1
{
    public static void Process()
    {
        StreamReader streamReader = new StreamReader("day1\\input1.txt");

        string line = string.Empty;
        var total = 0;
        while (!streamReader.EndOfStream)
        {
            line = streamReader.ReadLine();
            var filtered = line.Where(l => (int)l >= 48 && (int)l <= 57).ToList();
            
            var digit1 = filtered[0];
            var digit2 = filtered.Count > 1 ? filtered[filtered.Count - 1] : filtered[0];
            
            var calValues = String.Concat(digit1, digit2);
            total += int.Parse(calValues);
            Console.WriteLine("value:" + calValues);
        }

        Console.WriteLine(total);
    }

}

