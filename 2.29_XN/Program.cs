using System;
public class Mainclass
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Введите число от 100 до 999 (число десятков должно быть больше 0):");
        n = int.Parse(Console.ReadLine());
        string n1 = n.ToString();
        string b = n1.Remove(0, 1);
        b = b.Remove(1, 1);
        int z = int.Parse(b);
        if (n <= 999 && n >= 10 && z > 0)
        {
            string a = n1.Remove(1, 2);
            string c = n1.Remove(0, 2);
            string[] many = { b, a, c };
            string x = string.Join(null, many);
            Console.WriteLine($"Изначальное число х равно {x}");
        }
        else
        {
            Console.WriteLine("Введеное число неверно");
        }
       


    }
}
