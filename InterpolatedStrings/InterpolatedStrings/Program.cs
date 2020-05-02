using System;

namespace InterpolatedStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.

            string name = "Robert";
            var date = DateTime.Now;

            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfYear, date);

            Console.WriteLine($"Hello. {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now");
        }
    }
}
