

var number = 0;

for (int i = 1; i < 101; i++)
{
    number = i;



    if (number % 5 == 0 && number % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}
