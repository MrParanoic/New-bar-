using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOfMana = 5, maxValueOfMana = 10;
            int valueHp = 5, MaxValueOfHp = 10;
            
            while (true)
            {
                draw(valueHp, MaxValueOfHp, ConsoleColor.Red, 0);
                draw(valueOfMana, maxValueOfMana, ConsoleColor.Blue, 1);
                Console.Write("\nсна сколько хотите изменить красную полоску ? ");
                valueHp += Convert.ToInt32(Console.ReadLine());
                Console.Write("\nсна сколько хотите изменить синюю полоску  ");
                valueOfMana += Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
        static void draw(int value,int maxValue,ConsoleColor color,int pos ) 
        {
            ConsoleColor defalt = Console.BackgroundColor;
            string healgh = "";
            for (int i = 0; i < value; i++)
            {
                healgh += ' ';
                
            }
            Console.SetCursorPosition(0, pos);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(healgh);
            Console.BackgroundColor = defalt;
            healgh = "";
            for (int i = value; i < maxValue; i++)
            {
                healgh += ' ';
            }
            Console.Write(healgh);
            Console.Write(']');
        }
    }
}
