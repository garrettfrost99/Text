using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Text
{
    public class StringExercises
    {
        public void exerciseOne()
        {
            string input, cleanString;
            bool isSequential = false;

            Console.WriteLine("Enter some numbers separated by a hyphen: ");
            input = Console.ReadLine();
            cleanString = input.Replace("-", "");

            for(int i = 0; i < cleanString.Length - 1; i++)
            {
                if(cleanString[i] + 1 == cleanString[i+1])
                    isSequential = true;
                else
                {
                    isSequential = false;
                    break;
                }
            }

            for (int i = 0; i < cleanString.Length - 1; i++)
            {
                if (cleanString[i] - 1 == cleanString[i + 1])
                    isSequential = true;
                else
                {
                    isSequential = false;
                    break;
                }
            }

            if (isSequential)
                Console.WriteLine("numbers sequential");
        }
        public void exerciseTwo()
        {
            string input, cleanString;
            bool isDuplicate = false;

            Console.WriteLine("Enter some numbers separated by a hyphen: ");
            input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                return;

            cleanString = input.Replace("-", "");

            for (int j = 0; j < cleanString.Length; j++)
            {
                for (int i = 0; i < cleanString.Length; i++)
                {
                    if (cleanString[i] == cleanString[j] && i != j)
                        isDuplicate = true;
                }
            }

            if (isDuplicate)
                Console.WriteLine("duplicates");
        }
        public void exerciseThree()
        {
            string input;
            DateTime time;

            Console.WriteLine("Enter a date in 24hr format: ");
            input = Console.ReadLine();

            try
            {
                time = Convert.ToDateTime(input);
                input = time.ToString("HH:mm");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                return;
            }
            Console.WriteLine("OK");
        }
        public void exerciseFour()
        {
            string input, output, trimmedOutput;

            Console.WriteLine("Enter a few words: ");
            input = Console.ReadLine();

            output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
            trimmedOutput = output.Replace(" ", "");

            Console.WriteLine(trimmedOutput);
        }
        public void exerciseFive()
        {
            string input;
            int total = 0;

            Console.WriteLine("Enter a word: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    total++;
                }
            }

            Console.WriteLine(total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var exercise1 = new StringExercises();
            //exercise1.exerciseOne();

            //var exercise2 = new StringExercises();
            //exercise2.exerciseTwo();

            //var exercise3 = new StringExercises();
            //exercise3.exerciseThree();

            //var exercise4 = new StringExercises();
            //exercise4.exerciseFour();

            //var exercise5 = new StringExercises();
            //exercise5.exerciseFive();
        }
    }
}
