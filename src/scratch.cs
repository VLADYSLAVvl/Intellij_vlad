using System
public class test
{
    public static void Main()
    {
        string est1;
        string estado = "bien";
        Console.WriteLine("Hola que tal ");
        est1 = Convert.ToString(Console.ReadLine());
        if (est1 == estado)
        {
            Console.WriteLine("Me alegro mucho");
        } else {
            Console.WriteLine("Motivate");
        }
    }
}