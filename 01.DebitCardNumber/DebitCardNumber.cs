using System;


namespace CSharpIntroAndBasicSyntaxExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1 = int.Parse(Console.ReadLine());
            int code2 = int.Parse(Console.ReadLine());
            int code3 = int.Parse(Console.ReadLine());
            int code4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{code1:D4} {code2:D4} {code3:D4} {code4:D4}");

        }
    }
}
