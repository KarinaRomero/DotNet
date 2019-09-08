using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void PrintLine(int size = 10)
        {
            WriteLine("".PadLeft(size, '-'));
        }
        public static void PrintTitle(string title)
        {
            WriteLine(title);
        }
    }
}