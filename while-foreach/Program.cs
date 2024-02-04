namespace while_foreach;

class Program
{
    static void Main(string[] args)
    {

        int start = 0;
        
        while (start <= 100)
        {
            Console.WriteLine(start);
            start++;
        }
        char first = 'a';
        while (first <= 'z')
        {
            Console.Write(first + "\t");
            first++;
        }

        Console.WriteLine("#### FOR EACH ####");

        string[] cars = {"Audi", "Mercedes", "Ford", "Nissan", "Toyota"};

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

