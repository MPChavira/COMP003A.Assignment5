/*
 * Author: Michael Perez Chavira   
 * Course: COMP-003A
 * Purpose: Week 5 Methods and XML Comments
 */
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle");
            Console.WriteLine("Enter a single character: ");
            char inputCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Enter a whole number: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            IsoscelesTriangleBuilder(inputCharacter, size);
            PrintSeparator("Favorite Characters");
            CharacterInfo("Darth Vader", 1977);
            CharacterInfo("Kratos", 2005);
            CharacterInfo("Wolverine", 1974);
            CharacterInfo("Luke Skywalker", 1977);
            CharacterInfo("Batman", 1939);



        }
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Method with one parameter but no return value
        /// </summary>
        /// <param name="text">string text input</param>
        static void PrintSeparator(string text) {
            PrintSeparator();
            Console.WriteLine(text);
            PrintSeparator();
        }

        /// <summary>
        /// Outputs an isosceles triangle made by the inputCharacter
        /// </summary>
        /// <param name="inputChacter">The character used for building the isosceles triangle</param>
        /// <param name="size">The number of lines used in the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// calculates then outputs the age of the person born in the specific year
        /// </summary>
        /// <param name="year">The year someone was born</param>
        /// <return>The age of the person</return>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// outputs the age and name of the characters
        /// </summary>
        /// <param name="name">The characters name</param>
        /// <param name="birthYear">The year the character was created or born</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine("{0} ({1} years old)", name, age);
        }


    }
          
        

    }

