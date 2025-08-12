
public class TwistedFizzBuzz
{
    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void WithARange(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void NonSequential(int[] array)
    {
        foreach (var i in array)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void AlternativeDivisors(int x, int y, int z, int lenght)
    {
        for (int i = 1; i <= lenght; i++)
        {
            string output = string.Empty;
            if (i % z == 0)
            {
                output += "College";
            }
            if (i % x == 0)
            {
                output += "Poem";
            }
            if (i % y == 0)
            {
                output += "Writer";
            }
            if (output != string.Empty)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }

    public static void FizzBuzzBar(int lenght)
    {
        for (int i = 0; i <= lenght; i++)
        {
            string output = string.Empty;
            if (i % 5 == 0)
            {
                output += "Fizz";
            }
            else if (i % 9 == 0)
            {

                output += "Buzz";
            }
            else if (i % 27 == 0)
            {

                output += "Bar";
            }
            if (output != string.Empty)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void FromAPI()
    {
        // APIU WAS NOT WORKING AT THE TIME OF WRITING
    }
}

