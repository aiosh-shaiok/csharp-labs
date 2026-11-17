
using System;

class Program
{
    // Жолдан цифрларды алып тастау методы
    static string RemoveDigits(string text, out int digitCount)
    {
        string result = "";
        digitCount = 0;

        // Жолдағы әр символды тексеру
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            // Егер символ цифр болмаса, жаңа жолға қосамыз
            if (!char.IsDigit(ch))
            {
                result += ch;
            }
            else
            {
                // Цифр табылса, санын арттырамыз
                digitCount++;
            }
        }

        return result;
    }

    static void Main()
    {
        string text;

        // Бос жол енгізілмеуін тексеру
        do
        {
            Console.Write("Мәтінді енгізіңіз: ");
            text = Console.ReadLine() ?? "";
        }
        while (text.Length == 0);

        // Цифрларды алып тастау
        int count;
        string result = RemoveDigits(text, out count);

        // Нәтижені шығару
        Console.WriteLine();
        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Жаңа жол: [" + result + "]");
        Console.WriteLine("Алынған цифрлар саны: " + count);
    }
}
