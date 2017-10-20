using System;
using System.Collections.Generic;

namespace Specification.Net.Samples.MathOperations
{
    public class Bootstraper
    {
        private static List<int> _numbers;
        public static void Run()
        {
            Initialize();
            GenerateFakeNumbers();

            var menu = ShowMenu();
            ParseUserChoice(menu);
        }

        private static void ParseUserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.Write("Select Operations : Parameterized Spec:1  or Composite Spec :2 >> your choise : ");
            var choice = Console.ReadLine();
            return int.Parse(choice);
        }

        private static void GenerateFakeNumbers()
        {
            for (var i = -10; i < 30; i++)
            {
                _numbers.Add(i);
            }
        }

        private static void Initialize()
        {
            _numbers = new List<int>();
        }
    }
}
