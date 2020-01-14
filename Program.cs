using System;
using System.Globalization;

namespace DateT_TimeS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1990, 10, 5 , 13 , 5, 58 , DateTimeKind.Local);
            DateTime c1 = new DateTime(1990, 10, 5, 13, 5, 58, DateTimeKind.Utc);
            DateTime d2 = DateTime.ParseExact("10/05/1990 19:00:23", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(c1);
            Console.WriteLine(d2);
        }
    }
}
