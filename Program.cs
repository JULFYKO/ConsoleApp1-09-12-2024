internal class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1:");
        Console.WriteLine("\tIt's easy to win forgiveness for being wrong;\n\tbeing right is what gets you into real trouble.\n\tBjarne Stroustrup");

        Console.WriteLine("Task 2:");
        string numb1 = Console.ReadLine();
        string numb2 = Console.ReadLine();
        string numb3 = Console.ReadLine();
        string numb4 = Console.ReadLine();
        string numb5 = Console.ReadLine();

        int num1 = Convert.ToInt32(numb1);
        int num2 = Convert.ToInt32(numb2);
        int num3 = Convert.ToInt32(numb3);
        int num4 = Convert.ToInt32(numb4);
        int num5 = Convert.ToInt32(numb5);

        int sum = num1 + num2 + num3 + num4 + num5;
        int max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
        int min = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));
        int product = num1 * num2 * num3 * num4 * num5;

        Console.WriteLine("Sum: "+sum);
        Console.WriteLine("Max: "+max);
        Console.WriteLine("Min: "+min);
        Console.WriteLine("Product:"+product);

        Console.WriteLine("Task 3:");
        string numі = Console.ReadLine();
        if (numі.Length == 6)
        {
            int num = int.Parse(numі);
            int tm = 0;
            while (num > 0)
            {
                tm = tm * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine("Reversed: " + tm);
        }
        else Console.WriteLine("Error");
    }
}
